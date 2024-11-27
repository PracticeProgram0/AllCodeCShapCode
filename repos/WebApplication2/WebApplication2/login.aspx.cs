using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select user_type from tbl_login where user_id='"+TextBox1.Text+"'and password='"+TextBox2.Text+"'";
            SqlConnection cn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            cn.Open();
            SqlCommand cmd=new SqlCommand (s, cn);
                        SqlDataReader dr=cmd.ExecuteReader();

            if (dr.Read())
            {

                string utp = dr[0].ToString();
                if (utp == "user")
                {
                    Response.Redirect("user_dash.aspx");
                }
                else
                    Response.Redirect("admin_home.aspx");

            }
            else
            {
                Label1.Text = "invalid login...";
            }

        }
    }
}