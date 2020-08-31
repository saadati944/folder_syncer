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
        }
        private void Show_Local_IP_Address()
        {
            IPHostEntry IPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IPAddress in IPHostEntry.AddressList)
            {
                if (IPAddress.AddressFamily == AddressFamily.InterNetwork)
                    lstips.Items.Add(IPAddress.ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
