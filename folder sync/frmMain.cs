using System;
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
    }
}
