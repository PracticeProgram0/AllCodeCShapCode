using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Program
    {
        int a, b, c;
        void setdata(int x,int y)
        {
            a = x;
            b = y;
        }
        void add()
        {
            c = a + b;

            Console.WriteLine(c);
        }

        static void Main(string[] args ) 
        {
            Program p = new Program();
            p.setdata(500,200);
            
            p.add();
            Console.ReadKey();

        }
    }
}
