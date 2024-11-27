using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DATA_INSERTED
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            string q = "insert into tb_10 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            SqlConnection cn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            int x = cmd.ExecuteNonQuery();
            if (x >= 0)
                Response.Write("successfulyy inserteddddd");
            else
                Response.Write("not inserteddddd");



            TextBox1.Text = "";
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;


        }
     

        protected void Button2_Click(object sender, EventArgs e)
        {
            string q = "update tb_10 set name='" + TextBox1.Text + "',email='" + TextBox2.Text + "',mobile='" + TextBox3.Text + "'";
            SqlConnection cn = new SqlConnection(" Data Source=Hp;Initial Catalog=btps;Integrated Security=True ");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            int x = cmd.ExecuteNonQuery();
            if (x >= 0)
                Response.Write("successfulyy udatedddddd");
            else
                Response.Write("not updatedddddd");



            TextBox1.Text = "";
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
        }
    }
}