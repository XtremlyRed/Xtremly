
using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


namespace Xtremly.Core
{



    [DebuggerDisplay("{RemoteEndPoint}")]
    internal class UdpSession : ISession
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal Func<byte[], int, int, byte[]> Decompress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal Func<byte[], int, int, byte[]> Compress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] internal Action<ProtocolPacket, IPEndPoint> MessageSender;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private bool disposed;
        public IPEndPoint RemoteEndPoint { get; internal set; }

        public void Dispose()
        {
            disposed = true;
            Decompress = null;
            Compress = null;
            MessageSender = null;
        }

        public int Send(byte[] buffer, int offset, int length, PacketSetting setting = null)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpSession));
            }

            bool isCompress = setting?.IsCompressBuffer ?? false;
            if (isCompress)
            {
                buffer = Compress(buffer, offset, length);
                offset = 0;
            }

            ProtocolPacket packet = ProtocolPacket.BuildPacket(buffer, offset, length, setting);

            MessageSender(packet, RemoteEndPoint);
            return packet.Wait();
        }

        public Task<int> SendAsync(byte[] buffer, int offset, int length, PacketSetting setting = null)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpSession));
            }
            CancellationToken token = setting?.CancellationToken ?? CancellationToken.None;
            return Task.Factory.StartNew(() =>
            {
                return Send(buffer, offset, length, setting);
            }, token, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
        }
    }
}
