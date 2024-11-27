using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class btps
    {
        public void m1()
        {
            Console.WriteLine("parent class -method is calling");
        }
    }
    class C:btps
    {
        public void m1()
        {
            Console.WriteLine("child method ");
        }
    }

}
