using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btps2
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("zero parametrize constructor");
        }
        public Program(int x)
        {
            Console.WriteLine("1-parametrize constructor");
        }
        public Program(string a)
        {
            Console.WriteLine("1-parametrise constructor");
        }
        public Program(int i,int j,int k,string s)
        {
            Console.WriteLine("4- parametrise constructor is calling");
        }
        void m1()
        {
            Console.WriteLine("m1 method is calling");
        }
        static void Main(string[] args)
        {
            Program p = new Program(10);
            Program p1 = new Program("Ram");
            Program p2 = new Program(10, 20, 30, "manish");
                    p2.m1();
            Console.ReadKey();
        }
    }
}
