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
    /// <see cref="ITcpConnect"/>
    /// </summary>
    public interface ITcpConnect : ITcpServer
    {
        /// <summary>
        /// startup tcp connect
        /// </summary>
        /// <returns></returns>
        new IMessageTransfer RunAsync();


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
}
