using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program26
{
    public partial class Grid : System.Web.UI.Page
    {
        // Store a list of shows information
        protected List<Show> shows = new List<Show>();

        // It is better to show data using ASP.NET GridView control
        protected void Page_Load(object sender, EventArgs e)
        {
            // Add five shows information
            shows.Add(new Show
            {
                ID = 1,
                Channel = 5,
                EpisodeTitle = "ASP.NET Databinding",
                ScheduledTime = new DateTime(2017, 9, 12, 12, 0, 0),
                ShowTitle = "The C# Show"
            });

            shows.Add(new Show
            {
                ID = 2,
                Channel = 5,
                EpisodeTitle = "ASP.NET Styling",
                ScheduledTime =
                new DateTime(2017, 9, 12, 13, 0, 0),
                ShowTitle = "The C# Show"
            });

            shows.Add(new Show
            {
                ID = 3,
                Channel = 8,
                EpisodeTitle = "Inheritance",
                ScheduledTime =
                new DateTime(2017, 9, 16, 9, 0, 0),
                ShowTitle = "Learning C#"
            });

            shows.Add(new Show
            {
                ID = 4,
                Channel = 8,
                EpisodeTitle = "Partial Classes",
                ScheduledTime =
                new DateTime(2017, 9, 17, 9, 0, 0),
                ShowTitle = "Learning C#"
            });

            shows.Add(new Show
            {
                ID = 5,
                Channel = 8,
                EpisodeTitle = "Operator Overloading",
                ScheduledTime =
                new DateTime(2017, 9, 18, 9, 0, 0),
                ShowTitle = "Learning C#"
            });

            // Adding data source to Gridview control
            GridView1.DataSource = shows;
            GridView2.DataSource = shows;

            GridView2.AutoGenerateColumns = false;

            BoundField channelColumn = new BoundField();
            channelColumn.DataField = "Channel";
            channelColumn.HeaderText = "Channel";
            GridView2.Columns.Add(channelColumn);

            BoundField episodeColumn = new BoundField();
            episodeColumn.DataField = "EpisodeTitle";
            episodeColumn.HeaderText = "Episode";
            GridView2.Columns.Add(episodeColumn);

            // Binding styles with CSS by using code ("GridView" is class name in .css file).
            GridView1.CssClass = "GridView";
            GridView2.RowStyle.BackColor = Color.LightYellow;

            Page.DataBind();
        }
    }
}