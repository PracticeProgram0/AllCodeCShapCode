using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp15
{
    internal class Program
    {
         Program(int x)
        {
            Console.WriteLine("1-parametrize constructor");
        }
        Program(string s)
        {
            Console.WriteLine("1-string type parametrize");
        }
        void m1()
        {
            Console.WriteLine("m1 method is colling");
        }
        static Program()
        {
            Console.WriteLine("static constructor");
        }
        class C
        {
            void m2()
            {
                Console.WriteLine("child class method");
            }
            static void Main(string[] args)
            {
                Program p1 = new Program(10);
                Program p2 = new Program("Ram");
                
               
                Console.ReadKey();
            }
        }
    }
}
