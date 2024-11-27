using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_C_
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Rect obj = new Rect();
            obj.L = 5;
            obj.B = 10;
           Console.WriteLine( "peri is"+obj.peri());

               obj.area();
            Console.ReadKey();
        }
        
    }
}
