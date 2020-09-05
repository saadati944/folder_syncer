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

        #region create_connection
        /// <summary>
        /// connects to another socket that listens for a connection.
        /// </summary>
        /// <remarks>socket.connected</remarks>
        public bool connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ip, port);
            return socket.Connected;
        }

        /// <summary>
        /// listen for an incomming connection.
        /// </summary>
        /// <returns>socket.connected</returns>
        public bool listen()
        {
            TcpListener listener = new TcpListener(ip, port);
            listener.Start();
            socket = listener.AcceptSocket();
            listener.Stop();
            return socket.Connected;
        }

        //close the connected.
        public bool close()
        {
            socket.Close();
            return !socket.Connected;
        }

        #endregion

        #region packets_factory
        //create packets to send
        public packet[] create_packets(byte[] content, short mode)
        {
            //each packet can contain only 4082 bytes
            if (content.Length <= 4082)
                return new packet[] { new packet(mode, get_serie_ID(), 0, (short)content.Length, content.Length, content) };
            int packetscount = (content.Length - content.Length % 4082) / 4082;
            if (content.Length % 4082 != 0)
                packetscount++;
            packet[] packets = new packet[packetscount];
            int serieid = get_serie_ID();
            for (short i = 0; i < packetscount; i++)
                if (i != packetscount - 1)
                    packets[i] = new packet(mode, serieid, i, 4082, content.Length, content, 4082 * i);
                else
                    packets[i] = new packet(mode, serieid, i, (short)(content.Length - i * 4082), content.Length, content, i * 4082);
            return packets;
        }
        public byte[] join_packets(packet[] packets)
        {
            if (packets.Length == 0)
                return new byte[] { };
            List<byte> v = new List<byte>();
            for (int i = 0; i < packets.Length; i++)
            {
                foreach (packet x in packets)
                {
                    if (x.serieIndex != i)
                        continue;
                    v.AddRange(x.content);
                    if (x.contentLength < 4082)
                        v.RemoveRange(v.Count - (4082 - x.contentLength), (4082 - x.contentLength));
                }
            }
            return v.ToArray();
        }
        #endregion

        #region tools
        //generate a unique serie id
        private int get_serie_ID()
        {
            return _lastPacketid++;
        }
        #endregion
    }
    
}
