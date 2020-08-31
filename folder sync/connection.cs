using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folder_sync
{
    /// <summary>
    /// this is the connection class wich connects to another connection class over the socket and sends/receives data and other information.
    /// </summary>
    public class connection
    {
        public Socket socket;
        public IPAddress ip;
        public int port;

        public connection(IPAddress ip,int port)
        {
            this.ip = ip;
            this.port = port;
        }
    }
}
