using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
            string s = "insert into fri_1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            SqlConnection conn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(s,conn);
            int i =cmd.ExecuteNonQuery();
            if(i>0)
            {
                Response.Write("inserted data");
            }
            else
            {
                Response.Write("inserted data");

            }
        }
    }
}