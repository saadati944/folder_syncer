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
        //public variables
        public Socket socket;
        public IPAddress ip;
        public int port;
        private int _lastPacketid = 0;

        //rootpath is for saving incomming files.
        public string rootpath;

        //public events
        //todo : create events for connect, send, receive, ...

        

        public connection(IPAddress ip,int port,string rootpath="")
        {
            this.ip = ip;
            this.port = port;
            this.rootpath = rootpath;
        }


        #region tools
        //generate a unique serie id
        private int get_serie_ID()
        {
            return _lastPacketid++;
        }
        #endregion
    }
    
}
