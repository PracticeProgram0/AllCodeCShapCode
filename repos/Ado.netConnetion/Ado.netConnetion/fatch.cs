using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Ado.netConnetion
{
    internal class fatch
    {
        public static void Main(string[] args)
        {
            int id;
            Console.WriteLine("Enter id");
         id = int.Parse( Console.ReadLine());
            string t = "select*from tbl_emp where id="+id;
            SqlConnection con=new SqlConnection("Data Source=Hp;Initial Catalog=today;Integrated Security=True");
            con.Open();
            SqlCommand cmd =new SqlCommand(t, con);
           SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                for(int i = 0;i<4;i++)
                {
                    Console.WriteLine(dr[i]);
                }                
            }
            else
            {
                Console.WriteLine("No record found");
            }
            Console.ReadKey();  

        }



    }
}
