using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program25
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ChangeText_Click(object sender, EventArgs e)
        {
            TextToChange.Text = "It has changed!";
        }

        protected void ChangeTheColor(object sender, EventArgs e)
        {
            TextToChange.BackColor = System.Drawing.Color.Red;
        }
    }
}