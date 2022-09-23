using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace Xtremly.Core.Connect
{
    /// <summary>
    /// connect config 
    /// </summary>
    public interface IConnectConfiguration
    {
        /// <summary>
        /// bufer size
        /// </summary>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        IConnectConfiguration UseBufferSize(int bufferSize);

        /// <summary>
        /// local endpoint ip:127.0.0.1
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        IConnectConfiguration UseLocalEndPoint(int port);

        /// <summary>
        /// remote endpoint ip:127.0.0.1
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        IConnectConfiguration UseRemoteEndPoint(int port);

        /// <summary>
        /// local endpoint
        /// </summary>
        /// <param name="localEndPoint"></param>
        /// <returns></returns>
        IConnectConfiguration UseLocalEndPoint(EndPoint localEndPoint);

        /// <summary>
        /// remote endpoint
        /// </summary>
        /// <param name="remoteEndPoint"></param>
        /// <returns></returns>
        IConnectConfiguration UseRemoteEndPoint(EndPoint remoteEndPoint);

        /// <summary>
        /// execute when has exception
        /// </summary>
        /// <param name="errorCallback"></param>
        /// <returns></returns>
        IConnectConfiguration UseErrorCallback(Action<Exception> errorCallback);

        /// <summary>
        /// execute when recevied data 
        /// </summary>
        /// <param name="recevieCallback"></param>
        /// <returns></returns>
        IConnectConfiguration UseRecevieCallback(Action<IMessageTransfer, byte[]> recevieCallback);

        /// <summary>
        /// using udp
        /// </summary>
        /// <returns></returns>
        IUdpConnect UseUdpConnect();

        /// <summary>
        /// using tcp
        /// </summary>
        /// <returns></returns>
        ITcpConnect UseTcpConnect();
    }


    /// <summary>
    /// connect config 
    /// </summary>
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

        IConnectConfiguration IConnectConfiguration.UseBufferSize(int bufferSize)
        {
            this.bufferSize = bufferSize;
            return this;
        }

        IConnectConfiguration IConnectConfiguration.UseErrorCallback(Action<Exception> errorCallback)
        {
            this.errorCallback = errorCallback;
            return this;
        }

        IConnectConfiguration IConnectConfiguration.UseLocalEndPoint(EndPoint localEndPoint)
        {

            this.localEndPoint = localEndPoint;
            return this;
        }

        IConnectConfiguration IConnectConfiguration.UseLocalEndPoint(int port)
        {
            localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            return this;
        }
        IConnectConfiguration IConnectConfiguration.UseRemoteEndPoint(int port)
        {
            remoteEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            return this;
        }
        IConnectConfiguration IConnectConfiguration.UseRecevieCallback(Action<IMessageTransfer, byte[]> recevieCallback)
        {
            this.recevieCallback = recevieCallback;
            return this;
        }

        IConnectConfiguration IConnectConfiguration.UseRemoteEndPoint(EndPoint remoteEndPoint)
        {
            this.remoteEndPoint = remoteEndPoint;
            return this;
        }
         

        ITcpConnect IConnectConfiguration.UseTcpConnect()
        {
            return new TcpConnect(Copy());
        }

        IUdpConnect IConnectConfiguration.UseUdpConnect()
        {
            return new UdpConnect(Copy());
        }

        private ConnectConfiguration Copy()
        {
            return new ConnectConfiguration()
            {
                bufferSize = bufferSize,
                errorCallback = errorCallback,
                localEndPoint = localEndPoint,
                recevieCallback = recevieCallback,
                remoteEndPoint = remoteEndPoint
            };
        }
    }
}
