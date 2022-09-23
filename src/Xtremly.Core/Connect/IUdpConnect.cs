using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;


namespace Xtremly.Core.Connect
{
    public interface IUdpConnect
    {
        IMessageTransfer RunAsync();
    }


    public class UdpConnect : IUdpConnect
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly EndPoint emptyEndPoint = new IPEndPoint(IPAddress.Any, 0);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ConnectConfiguration hostConfiguration;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Socket socket;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AsyncTransferProxy asyncSendPool;


        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isDisposed;


        public UdpConnect(ConnectConfiguration hostConfiguration)
        {
            this.hostConfiguration = hostConfiguration;
        }

        public IMessageTransfer RunAsync()
        {
            if (hostConfiguration.localEndPoint is null)
            {
                throw new ArgumentNullException(nameof(hostConfiguration.localEndPoint));
            }
            if (hostConfiguration.bufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(hostConfiguration.bufferSize));
            }

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            socket.Bind(hostConfiguration.localEndPoint);
            socket.DontFragment = true;

            asyncSendPool = new AsyncTransferProxy(hostConfiguration.bufferSize);

            SocketAsyncEventArgs socketArgs = new();
            socketArgs.SetBuffer(new byte[hostConfiguration.bufferSize], 0, hostConfiguration.bufferSize);
            socketArgs.Completed += EndReceive;
            socketArgs.RemoteEndPoint = emptyEndPoint;
            BeginReceive(socketArgs);

            return new MessageTransfer(socket, hostConfiguration.remoteEndPoint, asyncSendPool, ThrowIfDisopsed);
        }


        /// <summary>
        /// 异步接收数据
        /// </summary>
        /// <param name="e"></param>
        private void BeginReceive(SocketAsyncEventArgs e)
        {
            ThrowIfDisopsed();

            if (socket.ReceiveFromAsync(e) == false)
            {
                EndReceive(this, e);
            }
        }
        /// <summary>
        /// completed handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndReceive(object sender, SocketAsyncEventArgs e)
        {
            ThrowIfDisopsed();

            if (e.BytesTransferred > 0 && e.SocketError == SocketError.Success)
            {
                byte[] currentReceviedBuffer = new byte[e.BytesTransferred];

                Buffer.BlockCopy(e.Buffer, 0, currentReceviedBuffer, 0, e.BytesTransferred);

                MessageTransfer tran = new(socket, hostConfiguration.remoteEndPoint, asyncSendPool, ThrowIfDisopsed);

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        hostConfiguration.recevieCallback?.Invoke(tran, currentReceviedBuffer);

                        currentReceviedBuffer = null;
                    }
                    catch (Exception e)
                    {
                        hostConfiguration.errorCallback?.Invoke(e);
                    }
                }, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);

            }

            BeginReceive(e);
        }

        private void ThrowIfDisopsed()
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException(nameof(UdpConnect));
            }
        }


        public void Dispose()
        {
            isDisposed = true;
            socket?.Close();
            socket?.Dispose();
            socket = null;
        }
    }
}
