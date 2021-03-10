using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Program27
{
    public partial class TestRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                // Setup breakpoint to check Request.Form.
                // The Forms collection contains all the data being sent back from the client.
                foreach (String requestInfo in Request.Form)
                {
                    Debug.WriteLine(requestInfo);
                }
            }

            // If the user is not authenticated, redirect to the login page.
            if (!Request.IsAuthenticated)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void RequestButton_Click(object sender, EventArgs e)
        {
            foreach (String requestInfo in Request.Form)
            {
                Debug.WriteLine(requestInfo);
            }
        }
    }
}