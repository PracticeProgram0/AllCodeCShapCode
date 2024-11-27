using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
       public int a = int.Parse(Console.ReadLine());
       public int b = int.Parse(Console.ReadLine());
        public int c = int.Parse(Console.ReadLine());
        public void m1()
        { 
          c = a + b;
        }
        static void Main(string[]args)
        {
            Program p1 = new Program();
                    p1.m1();
            Console.ReadKey();
        }
    }
}
