using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile && FileUpload2.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                string filePath = Path.Combine(Server.MapPath("~/Images"), fileName);

                // Validate file type and size (optional)

                FileUpload1.PostedFile.SaveAs(filePath);
                Image1.ImageUrl = "~/Images/" + fileName;

                string fileName1 = Path.GetFileName(FileUpload2.PostedFile.FileName);

                string filePath1 = Path.Combine(Server.MapPath("~/Images"), fileName1);


                FileUpload2.PostedFile.SaveAs(filePath1);
                Image2.ImageUrl = "~/Images/" + fileName1;



            }
        }
}