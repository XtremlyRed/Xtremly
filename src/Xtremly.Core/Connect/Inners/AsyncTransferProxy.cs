using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Xtremly.Core.Connect
{
    /// <summary>
    /// async send <see cref="SocketAsyncEventArgs"/> proxy
    /// </summary>
    internal class AsyncTransferProxy
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly int bufferSize;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ConcurrentStack<SocketAsyncEventArgs> socketArgsStack = new();

        /// <summary>
        /// new
        /// </summary>
        /// <param name="bufferSize"></param>
        /// <param name="socket"></param>
        public AsyncTransferProxy(int bufferSize)
        {
            this.bufferSize = bufferSize;
        }

        /// <summary>
        /// send completed handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendCompleted(object sender, SocketAsyncEventArgs e)
        {
            Release(e);
        }


        #region Public Methods
        /// <summary>
        /// acquire
        /// </summary>
        /// <returns></returns>
        public SocketAsyncEventArgs Popup()
        {
            if (socketArgsStack.TryPop(out SocketAsyncEventArgs e))
            {
                return e;
            }

            e = new SocketAsyncEventArgs();
            e.SetBuffer(new byte[bufferSize], 0, bufferSize);
            e.Completed += SendCompleted;
            return e;
        }
        /// <summary>
        /// release
        /// </summary>
        /// <param name="e"></param>
        public void Release(SocketAsyncEventArgs e)
        {
            socketArgsStack.Push(e);
        }
        /// <summary>
        /// sned async
        /// </summary>
        /// <param name="endPoint"></param>
        /// <param name="buffer"></param>
        /// <exception cref="ArgumentNullException">endPoint is null</exception>
        /// <exception cref="ArgumentNullException">payload is null or empty</exception>
        /// <exception cref="ArgumentOutOfRangeException">payload length > messageBufferSize</exception>
        public void SendAsync(Socket socket, byte[] buffer, int offset, int length)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }

            if (buffer.Length - offset < length || length > bufferSize)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            SocketAsyncEventArgs e = Popup();
            e.RemoteEndPoint = socket.RemoteEndPoint ?? throw new ArgumentNullException("endPoint");

            Buffer.BlockCopy(buffer, offset, e.Buffer, 0, length);

            e.SetBuffer(0, length);

            if (socket.SendToAsync(e) == false)
            {
                Release(e);
            }
        }


        public void SendAsync(Socket socket,EndPoint endPoint, byte[] buffer, int offset, int length)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }

            if (buffer.Length - offset < length || length > bufferSize)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            SocketAsyncEventArgs e = Popup();
            e.RemoteEndPoint = endPoint ?? throw new ArgumentNullException("endPoint");

            Buffer.BlockCopy(buffer, offset, e.Buffer, 0, length);

            e.SetBuffer(0, length);

            if (socket.SendToAsync(e) == false)
            {
                Release(e);
            }
        }
        #endregion
    }
}
