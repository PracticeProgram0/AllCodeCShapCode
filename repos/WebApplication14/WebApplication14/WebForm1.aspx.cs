using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication14
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s="insert into btps_2 values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"')";
            SqlConnection conn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Inserted data");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";

            }
            else
            {
                Response.Write("not inserted data");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string u = "update btps_1 set name='" + TextBox1.Text + "',email='" + TextBox2.Text + "',password='" + TextBox3.Text + "')";
            SqlConnection cn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            cn.Open();
            SqlCommand sq = new SqlCommand(u, cn);
            int i = sq.ExecuteNonQuery();
            if(i>0)
            {
                Response.Write("updated data");


            }
            else
            {
                Response.Write("not updated");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string u="Delete from btps_1 where id=TextBox3.Text";
            SqlConnection cn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(u, cn);
            int j = cmd.ExecuteNonQuery();
            if(j>0)
            {
                Response.Write("delete data");
            }
            else
            {
                Response.Write("not delete data");
            }
        }
    }
}