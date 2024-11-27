using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class p
    {
        public void m1()
        {
            Console.WriteLine("p- class ki m1 method is calling");
        }
    }
    class m : p
    {
        public void m2()
        {

            Console.WriteLine("m- class ki m1 method is callin");
        }
    }

    class D : m
    {
        public void m3()
        {
            Console.WriteLine("m3 method is calling");
        }
    }
}

      


