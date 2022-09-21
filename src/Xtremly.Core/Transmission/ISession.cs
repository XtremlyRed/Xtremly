
using System;
using System.Net;
using System.Threading.Tasks;

namespace Xtremly.Core
{
    public interface ISession : IDisposable
    {
        IPEndPoint RemoteEndPoint { get; }

        Task<int> SendAsync(byte[] buffer, int offset, int length, PacketSetting setting = null);

        int Send(byte[] buffer, int offset, int length, PacketSetting setting = null);
    }
}
