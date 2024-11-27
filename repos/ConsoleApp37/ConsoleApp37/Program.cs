using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Cal
    {
        int a, b, c;
        void add()
        {
            c = a + b;
                Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Cal obj = new Cal();
            obj.a = 10;
            obj.b = 20;
            obj.add();
            Console.ReadKey();

        }
    }
}
