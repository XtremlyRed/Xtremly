using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Xtremly.Core.Connect
{ 
    public interface IMessageTransfer
    {
        public EndPoint RemoteEndPoint { get; }

        IMessageTransfer Transfer(byte[] buffer, int offset, int length);
    }


    [DebuggerDisplay("{RemoteEndPoint}")]
    internal class MessageTransfer : IMessageTransfer
    {
        public EndPoint RemoteEndPoint { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly AsyncTransferProxy asyncSendPool;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Action disposeChecker;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Socket socket;

        public MessageTransfer(Socket socket, AsyncTransferProxy asyncSendPool, Action disposeChecker)
        {
            this.socket = socket;
            RemoteEndPoint = socket?.RemoteEndPoint;
            this.asyncSendPool = asyncSendPool;
            this.disposeChecker = disposeChecker;
        }

        public MessageTransfer(Socket socket,EndPoint remoteEndPoint,  AsyncTransferProxy asyncSendPool, Action disposeChecker)
        {
            this.socket = socket;
            RemoteEndPoint = remoteEndPoint;
            this.asyncSendPool = asyncSendPool;
            this.disposeChecker = disposeChecker;
        }

        public IMessageTransfer Transfer(byte[] buffer, int offset, int length)
        {
            disposeChecker?.Invoke();
            if (RemoteEndPoint is null)
            {
                throw new ArgumentNullException(nameof(RemoteEndPoint));
            }
            if(asyncSendPool is null)
            {
                throw new InvalidOperationException();
            }
            asyncSendPool.SendAsync(socket, socket?.RemoteEndPoint, buffer, offset, length);
            return this;
        }
    }
}
