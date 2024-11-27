using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        int a = 10;
        int b = 20;
       void m2()
        {
            int x = a + b;
            Console.WriteLine(x);

        }
        static void Main(string[] args)
        {
            Program program = new Program();    
                   program.m2();
            Console.ReadKey();

        }
    }
}
