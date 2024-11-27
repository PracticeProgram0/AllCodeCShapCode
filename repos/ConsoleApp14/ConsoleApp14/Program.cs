using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        int a;
        int b;
        int c;
        

        public static void Main(string[] ar)
        {
            Program p = new Program();

            p.a = int.Parse(Console.ReadLine());
            p.b = int.Parse(Console.ReadLine());
            p.c = p.a + p.b;

            Console.WriteLine(p.c);
            Console.ReadKey();
        }
    }
}

  
            

