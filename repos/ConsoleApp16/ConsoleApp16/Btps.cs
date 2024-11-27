using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Btps
    {
        public void m1()
        {
            Console.WriteLine("0 argument method ");
        }
        public void m1(int x)
        {
            Console.WriteLine("1 argument method "+x);
        }
        public void m1(string s)
        {
            Console.WriteLine("1 argument method "+s);
        }
        public void m1(int x,int y)
        {
            int m=x+y;  
            Console.WriteLine("two  parameter argument method "+m);

        }
    }
}
