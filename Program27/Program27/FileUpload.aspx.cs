using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program27
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // Destination: where to upload the file
            // The Server.MapPath() method returns the local path for the server.
            String localPath = Server.MapPath("~/UploadedFiles/");

            // Check if user has selected a file
            if (FileUpload1.HasFile)
            {
                try
                {
                    // Save in server folder
                    FileUpload1.PostedFile.SaveAs(localPath + FileUpload1.FileName);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}