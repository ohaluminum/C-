using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program27
{
    public partial class Tracing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                throw new ApplicationException("This is the fake exception.");
            }
            catch (ApplicationException ex)
            {

                Trace.Warn(ex.Message);
            }
        }
    }
}