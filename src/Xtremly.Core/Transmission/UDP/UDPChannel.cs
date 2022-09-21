
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Xtremly.Core
{
    [DebuggerDisplay("Local:{LocalEndPoint}   Remote:{RemoteIPEndPoint}")]
    internal sealed partial class UdpChannel : IUdpChannel
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal Func<byte[], int, int, byte[]> Decompress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal Func<byte[], int, int, byte[]> Compress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private readonly CancellationTokenSource cancellationTokenSource = new();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private readonly SemaphoreSlim Semaphore = new(1, 1);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private readonly AsyncBuffer<ProtocolPacket> WaitSendHandles = new();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private readonly ConcurrentDictionary<long, ProtocolPacket> WaitResponseHandles = new();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal readonly IPEndPoint RemoteIPEndPoint;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal readonly IPEndPoint LocalEndPoint;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private readonly UdpClient Client;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal Action<ISession, byte[]> ReceiveFunc;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal Action<Exception> exceptionCallback;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private bool disposed;

        internal UdpChannel(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpChannel));
            }
            //if (remoteEndPoint == null)
            //{
            //    throw new ArgumentNullException(nameof(remoteEndPoint));
            //}
            if (localEndPoint == null)
            {
                throw new ArgumentNullException(nameof(localEndPoint));
            }

            Client = new UdpClient(LocalEndPoint = localEndPoint);

            RemoteIPEndPoint = remoteEndPoint;

        }




        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                Semaphore.Release();
                cancellationTokenSource.Cancel();

                WaitSendHandles?.Dispose();

                Client?.Close();

                WaitResponseHandles?.Clear();
                Semaphore.Dispose();
            }
        }
        ~UdpChannel()
        {
            Dispose();
        }

        public int Send(byte[] buffer, int offset, int length, PacketSetting setting = null)
        {
            if (RemoteIPEndPoint is null)
            {
                throw new ArgumentNullException(nameof(RemoteIPEndPoint));
            }

            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpChannel));
            }
            ProtocolPacket packet = ProtocolPacket.BuildPacket(buffer, offset, length, setting);

            AddSenderQueue(packet, RemoteIPEndPoint);

            int sendCount = packet.Wait();
            return sendCount;
        }

        public Task<int> SendAsync(byte[] buffer, int offset, int length, PacketSetting setting = null)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpChannel));
            }
            CancellationToken token = setting?.CancellationToken ?? CancellationToken.None;
            return Task.Factory.StartNew(() =>
            {
                return Send(buffer, offset, length, setting);
            }, token, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
        }

        #region Run

        public IUdpChannel RunAsync()
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpChannel));
            }
            InnerSender();

            ConcurrentDictionary<int, ISession> Sessions = new();

            // iPAddresses?.ForEach(x => Client.JoinMulticastGroup(x));

            byte[] emptyBuffer = new byte[0];

            Client.BeginReceive(ReceiveCallback, Client);



            return this;
            void InnerSender()
            {
                Task.Factory.StartNew(async () =>
                {
                    while (!disposed)
                    {
                        try
                        {
                            ProtocolPacket protocol = await WaitSendHandles.PopupAsync(cancellationTokenSource.Token);

                            if (protocol.ReportArrived)
                            {
                                WaitResponseHandles[protocol.Counter] = protocol;
                            }
                            protocol.SendCount = Client.Send(protocol.SendBuffer, protocol.SendBuffer.Length, protocol.RemoteEndPoint);

                            protocol.Set();
                        }
                        catch (Exception e)
                        {
                            exceptionCallback?.Invoke(e);
                        }
                    }
                }, cancellationTokenSource.Token, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
            }

            void ReceiveCallback(IAsyncResult iar)
            {
                if (iar.AsyncState is not UdpClient udpClient || disposed)
                {
                    return;
                }

                if (!iar.IsCompleted)
                {
                    udpClient.BeginReceive(ReceiveCallback, udpClient);
                    return;
                }
                IPEndPoint receivedEndPoint = null;

                byte[] receiveBytes = udpClient.EndReceive(iar, ref receivedEndPoint);

                ProtocolPacket protocol = ProtocolPacket.FromBuffer(receiveBytes, 0, receiveBytes.Length, Decompress);

                if (protocol.ReportArrived)
                {
                    byte[] ipAddress = receivedEndPoint?.Address?.GetAddressBytes() ?? new byte[] { 127, 0, 0, 1 }; ;
                    IPEndPoint remoteEndPoint = new(new IPAddress(ipAddress), receivedEndPoint?.Port ?? 0);

                    protocol.Data = emptyBuffer;
                    protocol.Offset = 0;
                    protocol.DataLength = 0;
                    protocol.UsingRemoteEndPoint = true;
                    protocol.ReportArrived = false;
                    AddSenderQueue(protocol, remoteEndPoint);
                }

                Task.Factory.StartNew(() =>
                {
                    udpClient.BeginReceive(ReceiveCallback, udpClient);
                }, TaskCreationOptions.DenyChildAttach);

                if (WaitResponseHandles.TryRemove(protocol.Counter, out ProtocolPacket waitHandle))
                {
                    waitHandle?.Set();
                    return;
                }

                if (ReceiveFunc is null)
                {
                    return;
                }

                int key = receivedEndPoint.Address.GetHashCode() ^ receivedEndPoint.Port;

                ReceiveFunc.Invoke(Sessions.GetOrAdd(key, i => new UdpSession()
                {
                    RemoteEndPoint = receivedEndPoint,
                    Compress = Compress,
                    MessageSender = AddSenderQueue
                }), protocol.Data);

            }
        }


        private void AddSenderQueue(ProtocolPacket packet, IPEndPoint remoteEndPoint)
        {
            if (disposed)
            {
                return;
            }
            packet.RemoteEndPoint = remoteEndPoint;
            packet.SendBuffer = packet.ToBuffer();

            WaitSendHandles.Put(packet);
        }




        #endregion



        #region  Base

        public bool MulticastLoopback
        {
            get => Client.MulticastLoopback;
            set => Client.MulticastLoopback = value;
        }

        public bool DontFragment
        {
            get => Client.DontFragment;
            set => Client.DontFragment = value;
        }
        public short Ttl
        {
            get => Client.Ttl;
            set => Client.Ttl = value;
        }
        public bool EnableBroadcast
        {
            get => Client.EnableBroadcast;
            set => Client.EnableBroadcast = value;
        }
        public bool ExclusiveAddressUse
        {
            get => Client.ExclusiveAddressUse;
            set => Client.ExclusiveAddressUse = value;
        }


        //public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive)
        //{
        //    Client.JoinMulticastGroup(multicastAddr, timeToLive);
        //}
        //public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress)
        //{
        //    Client.JoinMulticastGroup(multicastAddr, localAddress);
        //}
        //public void JoinMulticastGroup(IPAddress multicastAddr)
        //{
        //    Client.JoinMulticastGroup(multicastAddr);
        //}
        //public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr)
        //{
        //    Client.JoinMulticastGroup(ifindex, multicastAddr);
        //}
        //public void DropMulticastGroup(IPAddress multicastAddr, int ifindex)
        //{
        //    Client.DropMulticastGroup(multicastAddr, ifindex);
        //}
        //public void DropMulticastGroup(IPAddress multicastAddr)
        //{
        //    Client.DropMulticastGroup(multicastAddr);
        //}
        //public void AllowNatTraversal(bool allowed)
        //{
        //    Client.AllowNatTraversal(allowed);
        //}
        #endregion

    }
}
