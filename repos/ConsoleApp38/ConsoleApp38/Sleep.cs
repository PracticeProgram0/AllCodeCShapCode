using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Sleep
    {
        int a, b, c;        // global variable

        void m1(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("sum is "+c);
        }
        void m2()
        {
            c = a*b;
            Console.WriteLine("multiply is"+c);
        }
        static void Main(string[] args)
        {
            Sleep sleep = new Sleep();
            sleep.m1(10,20);
            sleep.a = 5;
            sleep.b = 5;
            sleep.m2();

            Console.ReadKey();
        }

    }
}
