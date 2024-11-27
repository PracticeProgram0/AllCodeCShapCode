using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Security
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "ram" && TextBox2.Text == "seeta")
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
                Response.Redirect("~/Admin/admin_home.aspx");
                //Response.Redirect("~/Admin/admin_about.aspx");


            }
            else
            {
                Label1.Text = " Invalid Username and Password.....";
            }

        }
    }
}