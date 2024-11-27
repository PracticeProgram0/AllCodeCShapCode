using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "INSERT INTO dbl_reg VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + "'," + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text+')';
            SqlConnection cn = new SqlConnection("Data Source=hp;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(s, cn);
            int i = cmd.ExecuteNonQuery();
            if(i > 0)
            {
                Response.Write("inserted");
            }
            else
            {
                Response.Write("not inserted");
            }
        }
    }
}