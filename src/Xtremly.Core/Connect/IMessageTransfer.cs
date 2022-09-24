using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

using Xtremly.Core.Connect;

namespace Xtremly.Core
{
    /// <summary>
    /// message sender
    /// </summary>
    public interface IMessageTransfer
    {
        /// <summary>
        /// remote endpoint
        /// </summary>
        public EndPoint RemoteEndPoint { get; }

        /// <summary>
        /// send message to remote endpoint
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        IMessageTransfer Transfer(byte[] buffer, int offset, int length);
    }
}
