using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        int l, b;
        public int L { get => l; set => l = value; }
        public int B { get => b; set => b = value; }
     public Program()
        {
            l = 10;
            b = 20;
            Console.WriteLine(l);
            Console.WriteLine(b);

        }
        public Program(int l,int b)
        {
            this.l = l;
            this.b = b;
        }
        public void m1()
        {
            Console.WriteLine("m1- method calling");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(100,200);
            Console.ReadKey();
        }
    }
}
