using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Program24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * The NetworkInformation class contains a bunch of information:
             *  - the status of the network
             *  - the current IP addresses
             *  - the gateway being used by the current machine (and more)
             */
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                toolStripStatusLabel1.Text = "Connected";
            }
            else
            {
                toolStripStatusLabel1.Text = "Disconnected";
            }

        }
    }
}
