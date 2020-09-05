using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_sync
{
    public partial class frmMain : Form
    {
        //public variables.
        public connection con;
        public string path;



        public frmMain()
        {
            InitializeComponent();
        }

        private void modeChange(object sender, EventArgs e)
        {
            delaysecs.Enabled = ((RadioButton)sender).Checked;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Show_Local_IP_Address();
            connection c1 = new connection(IPAddress.Parse("127.0.0.1"), 1234);
            connection c2 = new connection(IPAddress.Parse("127.0.0.1"), 1234);
            
            c1.ev1 += C1_ev1;
            c2.ev1 += C2_ev1;

            Task.Run(new Action(()=> c2.listen()));
            c1.connect();

            c2.start_receive();
            c1.send(File.ReadAllBytes(@"file1.pdf"), 1);



            Application.Exit();
        }

        private void C1_ev1(object sender, EventArgs e) 
        {

        }
        private void C2_ev1(object sender, EventArgs e)
        {
            File.WriteAllBytes(@"file2.pdf", (byte[])sender);
        }

        private void Show_Local_IP_Address()
        {
            //show a list of all local ip addresses in the "lstips";
            IPHostEntry IPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IPAddress in IPHostEntry.AddressList)
            {
                if (IPAddress.AddressFamily == AddressFamily.InterNetwork)
                    lstips.Items.Add(IPAddress.ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //try to convert user inputs to ip and port.
            try
            {
                IPAddress ip= IPAddress.Parse(txtIPAddress.Text);
                int port = int.Parse(txtPort.Text);
                if (!Directory.Exists(txtPath.Text))
                    throw new Exception("path was not accessible !!!");

                //create a new connection with the given parameters.
                con = new connection(ip, port);
                path = txtPath.Text;
            }
            catch(Exception ex) 
            {
                lstLog.Items.Add("Error. cant connect. message : " + ex.Message);
            }
        }
    }
}
