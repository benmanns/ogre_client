using OgreIsland.Sockets;

namespace OgreIsland.Client
{
    public class Client : Socket
    {
        public Client()
            : base(Protocol.Delimited, Protocol.Xml)
        {
        }
    }
}
