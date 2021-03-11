using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program27
{
    public partial class Cookies : System.Web.UI.Page
    {
        // The user making the request.
        WebUser currentUser = new WebUser();

        // A list of users who are working with the application.
        List<WebUser> usersInDatabase = new List<WebUser>();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * PostBack is the process of submitting an ASP.NET page to the server for processing. 
             * There is something that a client machine is not able to accomplish and thus these details have to be 'posted back' to the server.
             * For example: PostBack is done if certain credentials of the page are to be checked against some sources (such as verification of username and password using database). 
             */

            // Save the cookies: the first section occurs automatically when you load the page the first time.
            if (!Page.IsPostBack)
            {
                // This is a first request then set the cookie

                // Create a GUID instance.
                Guid sessionGuid = new Guid();

                // Store the id as current user session id.  
                currentUser.SessionId = sessionGuid;

                // Tell the database about the new user.
                usersInDatabase.Add(currentUser);

                // Set the cookie.
                Response.Cookies.Add(new HttpCookie("SessionId", sessionGuid.ToString()));
            }
            else
            {
                // This is a postback: we need to get the cookie.
                string cookieSession = Request.Cookies.Get("SessionId").Value.ToString();
                Guid sessionGuid = new Guid(cookieSession);

                // Obtain the user information from the database.
                var returningUser =
                   from u in usersInDatabase
                   where u.SessionId.ToString() == sessionGuid.ToString()
                   select u;

                foreach (var user in returningUser)
                {
                    currentUser = user;
                }

                // Show the cookie value in the textbox.
                CookieValue.Text = cookieSession;
            }
        }

        public class WebUser
        {
            public Guid SessionId { get; set; }
        }
    }
}