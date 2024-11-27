using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn = new SqlConnection("Hp");
            cn.Open();
        }
    }
}
