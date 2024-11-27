using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp41
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter name ,address city , your city ....");
                string nm = Console.ReadLine();
                string ad = Console.ReadLine();
                string ct = Console.ReadLine();
                string q = "insert into tb1_emp values('" + nm + "','" + ad + "','" + ct + "')";


                SqlConnection cn = new SqlConnection("Data Source=Hp;Initial Catalog=btps;Integrated Security=True");

                cn.Open();
                SqlCommand cmd = new SqlCommand(q, cn);
                int i = cmd.ExecuteNonQuery();
                if (i >= 0)
                    Console.WriteLine("insetd  data ");
                else
                    Console.WriteLine("not inserteddddddd");

            Console.ReadKey();
            }
        }
    }


