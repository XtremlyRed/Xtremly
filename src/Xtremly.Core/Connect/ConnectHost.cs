using System.Net.Sockets;

namespace Xtremly.Core.Connect
{
    public static class ConnectHost
    { 
        public static IConnectConfiguration HostBuilder()
        {
            return new ConnectConfiguration();
        } 
    }
     
}
