using System.Net;

namespace Xtremly.Core.Connect
{
    public interface IUdpHostConfiguration
    {
        IPEndPoint LocalEndPoint { get; set; }

        IPEndPoint RemoteEndPoint { get; set; }

        short Ttl { get; set; }
        bool MulticastLoopback { get; set; }
        bool DontFragment { get; set; }
        bool EnableBroadcast { get; set; }
        bool ExclusiveAddressUse { get; set; }
        void AllowNatTraversal(bool allowed);
    }
}
