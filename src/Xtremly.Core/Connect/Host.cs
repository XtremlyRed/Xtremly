namespace Xtremly.Core.Connect
{
    public static class Host
    {
        public static IHostBuilder CreateTcpBuilder()
        {
            return null;
        }
        public static IUdpHostBuilder CreateUdpBuilder()
        {
            return new UdpHostBuilder();
        }
    }

    public interface IHost<THost> where THost : IHost<THost>
    {
        THost RunAsync();
    }


    public interface IUdpHost : IHost<IUdpHost>
    {

    }
}
