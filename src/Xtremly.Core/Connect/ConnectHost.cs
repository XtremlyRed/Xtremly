using Xtremly.Core.Connect;

namespace Xtremly.Core 
{
    /// <summary>
    ///  Connect Builder
    /// </summary>
    public static class ConnectBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IConnectConfiguration Builder()
        {
            return new ConnectConfiguration();
        }
    }
}
