using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program26
{
    public partial class Images : System.Web.UI.Page
    {
        /*
         * NOTE:
         * How to choose use HTML <img> tag or ASP.NET Image control?
         * Use HTML tag if the image is static.
         * Use ASP.NET image control if the image can be managed from the C# code.
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "20191215-2.jpg";
        }
    }
}