using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_C_
{
    internal class Rect
    {
        int l, b;
        public Rect()
        {
            l = 5;
            l = 5;
        }
        public int L { get => l; set => l = value; }
        public int B { get => b; set => b = value; }
        public void area()
        {
            int a = l * b;
            Console.WriteLine(" area is" + a);
        }
        public int peri()
        {
            int p = 2 * (l + b);
            return p;
        }
    }
}




