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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "insert into dev2 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','"+TextBox6.Text+"')";
            SqlConnection con = new SqlConnection(" Data Source=Hp;Initial Catalog=btps;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);

            int i = cmd.ExecuteNonQuery();

            if (i >= 0)
            {
                Response.Write("INSERTED SUCCESSFULLY");
            }
            else
            {
                Response.Write(" NOT INSERTED ");
            }
        }
    }
}