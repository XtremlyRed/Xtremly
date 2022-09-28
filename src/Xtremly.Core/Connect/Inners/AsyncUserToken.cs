using System;
using System.Net;
using System.Net.Sockets;

namespace Xtremly.Core.Connect
{
    public class AsyncUserToken : IDisposable
    {
        public Socket Socket { get; set; }

        public DateTime ConnectTime { get; set; }

        public EndPoint IpEndPoint { get; set; }

        public AnnularPool<byte> BufferPool { get; set; }

        public int PacketLength { get; set; }

        public int PacketOffset { get; set; }

        public byte[] PacketBuffer { get; set; }

        public void Dispose()
        {
            BufferPool = null;
            IpEndPoint = null;
            PacketBuffer = null;
            PacketLength = 0;
            PacketOffset = 0;
            Socket?.Close();
            Socket?.Dispose();
            Socket = null;

        }
    }
}
