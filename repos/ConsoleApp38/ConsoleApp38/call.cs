using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class call
    {
        int a;
        static int b;
        const int c = 30;
        readonly int d=50;
        static void Main(String[]args)

        {
            b = 20;
            Console.WriteLine(b);
            Console.WriteLine(c);
            call obj = new call();
            obj.a = 10;
            Console.WriteLine(obj.a);

            Console.WriteLine(obj.d);
           
            Console.ReadKey();
        }
    }
}
