using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class LOGINFULL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string S = "INSERT INTO LOGINFULL VALUES('"+TextBox1.Text+ "','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"','"+TextBox7.Text+"','"+TextBox8.Text+"')";
            SqlConnection con = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            con.Open();
            SqlCommand cmd=new SqlCommand(S,con);
            int i=cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("inserted ");
            }
            else {
                Response.Write("not inserted ");

            }


        }
    }
}