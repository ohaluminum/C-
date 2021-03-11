using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program27
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Reference to the parent node.
            string baseNode = SiteMap.CurrentNode.Title;

            // Check to make sure there are subpages.
            if (SiteMap.CurrentNode.HasChildNodes)
            {
                foreach (SiteMapNode sitemapKids in SiteMap.CurrentNode.ChildNodes)
                {
                    // Put the child node name in the listbox.
                    ListBox1.Items.Add(new ListItem(sitemapKids.Title));
                }
            }
        }
    }
}