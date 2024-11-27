using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
       static int n;
       
        static void add(int i)
        {
            n = int.Parse(Console.ReadLine());

            for (i=1;i<=n;i++)

            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            add(1);
           
            Console.ReadKey();

        }
    }
}
