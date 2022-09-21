using System;
using System.Threading.Tasks;
namespace Xtremly.Core
{
    public interface IUdpChannel : IDisposable
    {
        IUdpChannel RunAsync();

        Task<int> SendAsync(byte[] buffer, int offset, int length, PacketSetting setting = null);

        int Send(byte[] buffer, int offset, int length, PacketSetting setting = null);

    }
}
