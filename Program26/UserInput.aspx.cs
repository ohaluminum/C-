using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program26
{
    public partial class UserInput : System.Web.UI.Page
    {
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                phoneNumber = string.Format("({0}){1}-{2}", TextBox5.Text, TextBox6.Text, TextBox7.Text);
                return phoneNumber;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Formated Phone Number: " + PhoneNumber;
        }
    }
}