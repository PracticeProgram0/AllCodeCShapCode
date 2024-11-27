using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle obj = new circle(10);
            obj.area();
            Rect r1 = new Rect(7, 5);
            r1.area();
            Console.ReadKey();
        }
    }
}
