using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Xtremly.Core.Connect
{
    /// <summary>
    /// <see cref="ITcpConnect"/>
    /// </summary>
    public interface ITcpConnect
    {
        /// <summary>
        /// startup tcp connect
        /// </summary>
        /// <returns></returns>
        IMessageTransfer RunAsync();
    }

    /// <summary>
    /// <see cref="ITcpServer"/>
    /// </summary>
    public interface ITcpServer
    {
        /// <summary>
        /// accept socket 
        /// </summary>
        /// <param name="acceptCallback"></param>
        /// <returns></returns>
        ITcpServer UseAccept(Action<IMessageTransfer> acceptCallback);

        /// <summary>
        /// set  backlog
        /// </summary>
        /// <param name="backlog"></param>
        /// <returns></returns>
        ITcpServer UseListen(int backlog);
        /// <summary>
        /// startup tcp connect
        /// </summary>
        /// <returns></returns>
        void RunAsync();
    }


    /// <summary>
    /// <see cref="TcpConnect"/>
    /// </summary>
    public class TcpConnect : ITcpConnect, ITcpServer
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly EndPoint emptyEndPoint = new IPEndPoint(IPAddress.Any, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ConnectConfiguration connectConfiguration;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Socket socket;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AsyncTransferProxy asyncSendPool;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isDisposed;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int backlog = -1;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Action<IMessageTransfer> acceptCallback;

        /// <summary>
        /// create tcp connect by  <paramref name="connectConfiguration"/>
        /// </summary>
        /// <param name="connectConfiguration"></param>
        public TcpConnect(ConnectConfiguration connectConfiguration)
        {
            this.connectConfiguration = connectConfiguration;
        }
        void ITcpServer.RunAsync()
        {
            SocketBuilder();

            if (backlog <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(backlog));
            }
            socket.Listen(backlog);
            BeginAccept();
        }


        /// <summary>
        /// startup tcp connect
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IMessageTransfer RunAsync()
        {
            SocketBuilder();

            if (connectConfiguration.remoteEndPoint is null)
            {
                throw new ArgumentNullException(nameof(connectConfiguration.remoteEndPoint));
            }

            BeginReceive(connectConfiguration.remoteEndPoint, socket);

            return new MessageTransfer(socket, asyncSendPool, ThrowIfDisopsed);
        }


        private void SocketBuilder()
        {
            if (connectConfiguration.localEndPoint is null)
            {
                throw new ArgumentNullException(nameof(connectConfiguration.localEndPoint));
            }
            if (connectConfiguration.bufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(connectConfiguration.bufferSize));
            }

            asyncSendPool = new AsyncTransferProxy(connectConfiguration.bufferSize);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            socket.Bind(connectConfiguration.localEndPoint);
            socket.DontFragment = true;

        }

        /// <summary>
        /// backlog
        /// </summary>
        /// <param name="backlog"></param>
        /// <returns></returns>
        public ITcpServer UseListen(int backlog)
        {
            this.backlog = backlog;
            return this;
        }

        /// <summary>
        /// acceptCallback
        /// </summary>
        /// <param name="acceptCallback"></param>
        /// <returns></returns>
        public ITcpServer UseAccept(Action<IMessageTransfer> acceptCallback)
        {
            this.acceptCallback = acceptCallback;
            return this;
        }


        private void BeginAccept()
        {
            socket.BeginAccept(asyncResult =>
            {
                if (asyncResult.IsCompleted)
                {
                    Task.Factory.StartNew(() =>
                    {
                        Socket acceptSocket = socket.EndAccept(asyncResult);

                        BeginReceive(acceptSocket.RemoteEndPoint, acceptSocket);

                        if (acceptCallback != null)
                        {
                            acceptCallback.Invoke(new MessageTransfer(acceptSocket, asyncSendPool, ThrowIfDisopsed));
                        }
                    }, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
                }

                BeginAccept();

            }, socket);
        }
         
        private void BeginReceive(EndPoint remoteEndPoint, Socket socket)
        {

            SocketAsyncEventArgs socketArgs = new()
            {
                RemoteEndPoint = remoteEndPoint,
                UserToken = socket
            };

            if (socket.RemoteEndPoint is null)
            {
                bool connectResult = socket.ConnectAsync(socketArgs);
                if (connectResult)
                {
                    socketArgs.Dispose();
                }
            }

            socketArgs = asyncSendPool.PopupEventArgs();
            socketArgs.RemoteEndPoint = remoteEndPoint;
            socketArgs.UserToken = socket;
            socketArgs.Completed += EndReceive;
            BeginReceive(socketArgs);
        }

        /// <summary>
        /// 异步接收数据
        /// </summary>
        /// <param name="e"></param>
        private void BeginReceive(SocketAsyncEventArgs e)
        {
            ThrowIfDisopsed();

            if (e.UserToken is Socket acceptSocket)
            {
                if (acceptSocket.ReceiveFromAsync(e) == false)
                {
                    //EndReceive(acceptSocket, e);
                }
            }
        }

        /// <summary>
        /// completed handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndReceive(object sender, SocketAsyncEventArgs e)
        {
            e.Completed -= EndReceive;

            ThrowIfDisopsed();

            if (e.BytesTransferred > 0 && e.SocketError == SocketError.Success)
            {
                byte[] currentReceviedBuffer = new byte[e.BytesTransferred];

                Buffer.BlockCopy(e.Buffer, 0, currentReceviedBuffer, 0, e.BytesTransferred);

                MessageTransfer transfer = new(e.UserToken as Socket, asyncSendPool, ThrowIfDisopsed);

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        connectConfiguration.recevieCallback?.Invoke(transfer, currentReceviedBuffer);

                        currentReceviedBuffer = null;
                    }
                    catch (Exception ex)
                    {
                        connectConfiguration.errorCallback?.Invoke(ex);
                    }
                }, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);

            }

            if (e.UserToken is Socket socket)
            {
                BeginReceive(socket.RemoteEndPoint, socket);
            }
        }

        private void ThrowIfDisopsed()
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnect));
            }
        }
         
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            isDisposed = true;
            socket?.Close();
            socket?.Dispose();
            socket = null;

            asyncSendPool?.Dispose();
            asyncSendPool = null;
        }
    }
}
