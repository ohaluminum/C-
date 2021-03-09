using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program26
{
    public partial class Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table1.BorderColor = Color.Black;
            Table1.GridLines = GridLines.Both;

            TableCell11.Text = "1";
            TableCell12.Text = "2";
            TableCell13.Text = "3";
            TableCell21.Text = "4";
            TableCell22.Text = "5";
            TableCell23.Text = "6";
            TableCell31.Text = "7";
            TableCell32.Text = "8";
            TableCell33.Text = "9";
        }
    }
}