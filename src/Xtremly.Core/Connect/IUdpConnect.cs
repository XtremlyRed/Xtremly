using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;


namespace Xtremly.Core
{
    /// <summary>
    /// IUdpConnect
    /// </summary>
    public interface IUdpConnect
    {
        /// <summary>
        /// startup udp connect
        /// </summary>
        /// <returns></returns>
        IMessageTransfer RunAsync();
    }
}
