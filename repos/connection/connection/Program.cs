using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nm, ad, ct;
            Console.WriteLine("Enter name address and city");
            nm = Console.ReadLine();
            ad = Console.ReadLine();
            ct = Console.ReadLine();
            string q = "insert into tbl_emp values('" + nm + "','" + ad + "','" + ct + "',)";
            SqlConnection con = new SqlConnection("Data Source=Hp;Initial Catalog=today;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Console.WriteLine("Inserted successfully");
            }
            else
            {
                Console.WriteLine("Not inserted");
            }


            Console.ReadKey();


        }
    }
}
