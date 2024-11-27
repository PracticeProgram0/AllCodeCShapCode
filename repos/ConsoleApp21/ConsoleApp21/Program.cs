using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        public void m1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = a + b+c;
            Console.WriteLine("sum is"+d);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
           obj.m1();
            Console.ReadKey();

        }
    }
}
