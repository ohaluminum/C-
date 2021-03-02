using System;
using System.Windows.Forms;
using System.Security.Principal;

namespace Program20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //The WindowsIdentity object represents the current windows user: get the user's identity.
            WindowsIdentity CurrIdentity = WindowsIdentity.GetCurrent();

            //The WindowsPrincipal object can check the membership of a windows user: obtain information about the user's rights.
            WindowsPrincipal CurrPrincipal = new WindowsPrincipal(CurrIdentity);

            //Determine which buttons to show based on the user's rights.
            if (CurrPrincipal.IsInRole(WindowsBuiltInRole.User))
            {
                //Usually run as normal user.
                UserButton.Visible = true;
            }
            else if (CurrPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                AdminButton.Visible = true;
            }
            else if (CurrPrincipal.IsInRole(WindowsBuiltInRole.Guest))
            {
                GuestButton.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
