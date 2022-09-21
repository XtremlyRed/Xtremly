using System;

namespace Xtremly.Core.Connect
{
    public interface IUdpHostBuilder : IHostBuilder
    {
        IUdpHostBuilder ConfigureHostConfiguration(Action<IUdpHostConfiguration> configureDelegate);

        IUdpHost Build();
    }


    internal class UdpHostBuilder : IUdpHostBuilder
    {
        public IUdpHost Build()
        {
            throw new NotImplementedException();
        }

        public IUdpHostBuilder ConfigureHostConfiguration(Action<IUdpHostConfiguration> configureDelegate)
        {


            return this;
        }
    }
}
