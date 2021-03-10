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
            String localPath = Server.MapPath("~/UploadedFiles/");

            if (FileUpload1.HasFile)
            {
                try
                {
                    FileUpload1.PostedFile.SaveAs(
                        localPath + FileUpload1.FileName);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}