using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DATA_INSERTED
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        string s = "insert into tb22 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','"+TextBox4.Text+"')";

         SqlConnection con = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand(s,con);
            int i = cmd.ExecuteNonQuery();
            if (i >= 0)
            {
                Response.Write("Inserted data");
            }
            else
            {
                Response.Write(" Not Inserted data");
                TextBox1.Text = "";
                TextBox2.Text = string.Empty;
                TextBox3.Text = string.Empty;

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string s = "insert into tb22 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";

            SqlConnection con = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand(s, con);
            int i = cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                TextBox1.Text = dr[1].ToString();
                TextBox2.Text = dr[2].ToString();
                TextBox3.Text = dr[3].ToString();


            }
            else
            {
                Response.Write("record not found....");
                TextBox1.Text = "";
                TextBox2.Text = string.Empty;
                TextBox3.Text = string.Empty;

            }









            }
        }
}