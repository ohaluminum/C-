using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program26
{
    public partial class TableMarkupDataBinding : System.Web.UI.Page
    {
        // Check Show class in Show.cs file
        protected Show show;

        // ------------------------------ DATA BINDING ---------------------------------

        // NOTE: It's better to set property value in the code-behind, rather than in the markup.

        protected void Page_Load(object sender, EventArgs e)
        {
            Table1.BorderColor = Color.Black;
            Table1.GridLines = GridLines.Both;
            
            // The object information will be retrieved from the database or the service in a real project.
            show = new Show
            {
                ID = 1,
                Channel = 5,
                EpisodeTitle = "ASP.NET Databinding",
                ScheduledTime = new DateTime(2017, 9, 12, 12, 0, 0),
                ShowTitle = "The C# Show"
            };

            // Using mark-up data binding
            Page.DataBind();
        }
    }
}