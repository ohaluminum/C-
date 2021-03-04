using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using System.Net.Mail;

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

        private void button1_Click(object sender, EventArgs e)
        {
            DownLoadWebFile(@"https://uh.edu", @"D:\Program\homepage.txt");
        }

        //Textbook Example about downloading a file from the Internet.
        private void DownLoadWebFile(string remoteFile, string localFile)
        {
            //Create the stream and request objects.
            FileStream localFileStream = new FileStream(localFile, FileMode.OpenOrCreate);
            WebRequest webRequest = WebRequest.Create(remoteFile);

            //Configure the request.
            webRequest.Method = WebRequestMethods.Http.Get;

            //Configure the response to the request.
            WebResponse webResponse = webRequest.GetResponse();
            Stream webResponseStream = webResponse.GetResponseStream();

            //Process the response by downloading data.
            byte[] buffer = new byte[1024];
            int bytesRead = webResponseStream.Read(buffer, 0, 1024);
            while (bytesRead > 0)
            {
                localFileStream.Write(buffer, 0, bytesRead);
                bytesRead = webResponseStream.Read(buffer, 0, 1024);
            }

            //Close the streams.
            localFileStream.Close();
            webResponseStream.Close();
        }
    }
}
