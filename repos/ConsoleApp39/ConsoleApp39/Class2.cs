using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Class2
    {
        int a, b, c;

        public int A{ get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public int C { get => c; set => c = value; }
        void m1()
        {
            c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.a= 100;
            obj.b = 200;
            obj.m1();
            Console.ReadKey();
        }

    }
}


