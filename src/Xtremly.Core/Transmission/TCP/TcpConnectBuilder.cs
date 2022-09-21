using System;
using System.Diagnostics;
using System.Net;

namespace Xtremly.Core
{
    public class TcpConnectBuilder : IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Func<byte[], int, int, byte[]> Decompress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Func<byte[], int, int, byte[]> Compress;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private IPEndPoint LocalIPEndPoint;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private IPEndPoint RemoteIPEndPoint;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private bool disposed;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Action<ISession, byte[]> ReceiveFunc;
        public TcpConnectBuilder()
        {
            Decompress = ProtocolPacket.Decompress;
            Compress = ProtocolPacket.Compress;
        }

        public TcpConnectBuilder UseLocalIPEndPoint(IPAddress localIp, int localPort)
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
        public virtual TcpConnectBuilder UseDecompressFunc(Func<byte[], int, int, byte[]> decompressFunc)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            Decompress = decompressFunc ?? throw new ArgumentNullException(nameof(decompressFunc));
            return this;
        }
        public TcpConnectBuilder UseRemoteIPEndPoint(IPAddress remoteIp, int remotePort)
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
        public virtual TcpConnectBuilder UseCompressFunc(Func<byte[], int, int, byte[]> compressFunc)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            Compress = compressFunc ?? throw new ArgumentNullException(nameof(compressFunc));
            return this;
        }
        public TcpConnectBuilder UseReceiveCallback(Action<ISession, byte[]> receiveCallback)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnectBuilder));
            }

            ReceiveFunc = receiveCallback ?? throw new ArgumentNullException(nameof(receiveCallback));
            return this;
        }

        public void Dispose()
        {
            disposed = true;
        }
    }
}


