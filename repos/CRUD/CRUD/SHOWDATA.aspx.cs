using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class SHOWDATA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = "select * from BT1";
            SqlConnection cn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(q, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();

            





        }
    }
}