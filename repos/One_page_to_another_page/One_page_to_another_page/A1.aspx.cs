using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace One_page_to_another_page
{
    public partial class A1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           //Response.Redirect("http://www.google.com");
            Server.Transfer("A2.aspx");

        }
    }
}