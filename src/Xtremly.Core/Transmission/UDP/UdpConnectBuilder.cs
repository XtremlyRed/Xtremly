
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Xtremly.Core
{

    public class UdpConnectBuilder
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Func<byte[], int, int, byte[]> Decompress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Func<byte[], int, int, byte[]> Compress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary<string, object> configs = new();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Action<ISession, byte[]> ReceiveFunc;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private IPEndPoint LocalIPEndPoint;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private IPEndPoint RemoteIPEndPoint;
        // [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<IPAddress> JoinMulticastGroup = new();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Action<Exception> ExceptionCallback;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private bool disposed;
        public UdpConnectBuilder()
        {
            Decompress = ProtocolPacket.Decompress;
            Compress = ProtocolPacket.Compress;
        }

        private UdpConnectBuilder UseDontFragment(bool dontFragment)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            configs.Add(nameof(UdpClient.DontFragment), dontFragment);
            return this;
        }

        public UdpConnectBuilder UseEnableBroadcast(bool enableBroadcast)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }
            configs.Add(nameof(UdpClient.EnableBroadcast), enableBroadcast);
            return this;
        }

        public UdpConnectBuilder UseExclusiveAddress(bool exclusiveAddressUse)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }
            configs.Add(nameof(UdpClient.ExclusiveAddressUse), exclusiveAddressUse);
            return this;
        }

        public UdpConnectBuilder UseMulticastLoopback(bool multicastLoopback)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }
            configs.Add(nameof(UdpClient.MulticastLoopback), multicastLoopback);
            return this;
        }
        public UdpConnectBuilder UseTtl(short ttl)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }
            configs.Add(nameof(UdpClient.Ttl), ttl);
            return this;
        }

        //public UdpConnectBuilder UseJoinMulticastGroup(IPAddress iPAddress)
        //{
        //    if (disposed)
        //    {
        //        throw new ObjectDisposedException(nameof(UdpConnectBuilder));
        //    }
        //    if (iPAddress == null)
        //    {
        //        throw new ArgumentNullException(nameof(iPAddress));
        //    }

        //    JoinMulticastGroup.Add(iPAddress);

        //    return this;
        //}

        public UdpConnectBuilder UseReceiveCallback(Action<ISession, byte[]> receiveCallback)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            ReceiveFunc = receiveCallback ?? throw new ArgumentNullException(nameof(receiveCallback));
            return this;
        }

        public UdpConnectBuilder UseExceptionCallback(Action<Exception> exceptionCallback)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            ExceptionCallback = exceptionCallback ?? throw new ArgumentNullException(nameof(exceptionCallback));
            return this;
        }

        public UdpConnectBuilder UseLocalIPEndPoint(IPAddress localIp, int localPort)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }
            if (localIp == null)
            {
                throw new ArgumentNullException(nameof(localIp));
            }

            if (localPort <= 0)
            {
                throw new ArgumentException(nameof(localPort));
            }

            LocalIPEndPoint = new IPEndPoint(localIp, localPort);
            return this;
        }
        public UdpConnectBuilder UseRemoteIPEndPoint(IPAddress remoteIp, int remotePort)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }
            if (remoteIp == null)
            {
                throw new ArgumentNullException(nameof(remoteIp));
            }

            if (remotePort <= 0)
            {
                throw new ArgumentException(nameof(remotePort));
            }

            RemoteIPEndPoint = new IPEndPoint(remoteIp, remotePort);
            return this;
        }


        public virtual IUdpChannel Build()
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }
            if (LocalIPEndPoint is null)
            {
                IReadOnlyList<int> targetPort = TransmissionAssist.GetAvailablePort(1);
                LocalIPEndPoint = new IPEndPoint(IPAddress.Any, targetPort.First());
            }

            //if (RemoteIPEndPoint is null)
            //{
            //    throw new ArgumentNullException(nameof(RemoteIPEndPoint));
            //}

            UdpChannel udpChannel = new(LocalIPEndPoint, RemoteIPEndPoint)
            {
                Decompress = Decompress,
                Compress = Compress,

                ReceiveFunc = ReceiveFunc,
                exceptionCallback = ExceptionCallback,
                //  iPAddresses = JoinMulticastGroup,
            };

            Type type = typeof(UdpClient);
            foreach (KeyValuePair<string, object> item in configs)
            {
                type.GetProperty(item.Key)?.SetValue(udpChannel, item.Value);
            }

            return udpChannel;
        }

        public virtual void Dispose()
        {
            disposed = true;

            Decompress = null;
            Compress = null;
            configs = null;
            ReceiveFunc = null;
            LocalIPEndPoint = null;
            RemoteIPEndPoint = null;
            // JoinMulticastGroup = null;
            ExceptionCallback = null;
        }

        public virtual UdpConnectBuilder UseDecompressFunc(Func<byte[], int, int, byte[]> decompressFunc)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            Decompress = decompressFunc ?? throw new ArgumentNullException(nameof(decompressFunc));
            return this;
        }

        public virtual UdpConnectBuilder UseCompressFunc(Func<byte[], int, int, byte[]> compressFunc)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            Compress = compressFunc ?? throw new ArgumentNullException(nameof(compressFunc));
            return this;
        }
    }
}
