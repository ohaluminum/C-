using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program26
{
    public partial class TableCodeBehindDataBinding : System.Web.UI.Page
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

            // Using code-behind data binding
            TableCell1.Text = show.ID.ToString();
            TableCell2.Text = show.Channel.ToString();
            TableCell3.Text = show.EpisodeTitle;
            TableCell4.Text = show.ScheduledTime.ToString();
            TableCell5.Text = show.ShowTitle;
        }
    }
}