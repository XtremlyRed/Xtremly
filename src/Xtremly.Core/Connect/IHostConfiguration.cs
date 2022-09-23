using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace Xtremly.Core.Connect
{
    public interface IConnectConfiguration
    {
        IConnectConfiguration UseBufferSize(int bufferSize);

        IConnectConfiguration UseLocalEndPoint(int port);

        IConnectConfiguration UseRemoteEndPoint(int port);

        IConnectConfiguration UseLocalEndPoint(EndPoint localEndPoint);

        IConnectConfiguration UseRemoteEndPoint(EndPoint remoteEndPoint);

        IConnectConfiguration UseErrorCallback(Action<Exception> errorCallback);

        IConnectConfiguration UseRecevieCallback(Action<IMessageTransfer, byte[]> recevieCallback);

        IUdpConnect UseUdpConnect();

        ITcpConnect UseTcpConnect();
    }

    public class ConnectConfiguration : IConnectConfiguration
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal int bufferSize; 

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal Action<Exception> errorCallback;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal EndPoint localEndPoint;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal Action<IMessageTransfer, byte[]> recevieCallback;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal EndPoint remoteEndPoint;

        public IConnectConfiguration UseBufferSize(int bufferSize)
        {
            this.bufferSize = bufferSize;
            return this;
        }

        public IConnectConfiguration UseErrorCallback(Action<Exception> errorCallback)
        {
            this.errorCallback = errorCallback;
            return this;
        }

        public IConnectConfiguration UseLocalEndPoint(EndPoint localEndPoint)
        {
            
            this.localEndPoint = localEndPoint;
            return this;
        }

        public IConnectConfiguration UseLocalEndPoint(int port)
        {
            localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            return this;
        }
        public IConnectConfiguration UseRemoteEndPoint(int port)
        {
            this.remoteEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            return this;
        }
        public IConnectConfiguration UseRecevieCallback(Action<IMessageTransfer, byte[]> recevieCallback)
        {
            this.recevieCallback = recevieCallback;
            return this;
        }

        public IConnectConfiguration UseRemoteEndPoint(EndPoint remoteEndPoint)
        {
            this.remoteEndPoint = remoteEndPoint;
            return this;
        }

     

        public ITcpConnect UseTcpConnect()
        {
            return new TcpConnect(Copy());
        }

        public IUdpConnect UseUdpConnect()
        {
            return new UdpConnect(Copy());
        }

        private ConnectConfiguration Copy()
        {
            return new ConnectConfiguration()
            {
                bufferSize = bufferSize,
                errorCallback = errorCallback,
                localEndPoint = (localEndPoint),
                recevieCallback = recevieCallback,
                remoteEndPoint = remoteEndPoint
            };
        }
    }
}
