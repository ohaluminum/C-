using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program26
{
    public partial class Text : System.Web.UI.Page
    {
        /*
         * NOTE: 
         * How to choose use HTML text or ASP.NET Label control?
         * Use text if the text is static. 
         * Use a label if the text will need to change based on input from the user or the server. 
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "This is sometext from the codebehind.";
        }
    }
}