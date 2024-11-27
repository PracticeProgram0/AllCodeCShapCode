using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test

    {
        int a, b, c;
        void m1()
        {
            int x=a+b+c;
            Console.WriteLine(x);
        }
        static void Main(string[] args)

        {
          Test t=new Test();
            t.a = 10;
            t.b = 20;
            t.c = 5;
            t.m1();
            Console.ReadKey();
          

        }
    }
}
