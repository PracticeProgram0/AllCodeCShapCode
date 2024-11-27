using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        int a;
        int b;
        int c;
       void btps()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);
            
        }
        public Program(int x)
        {
            c = x;
            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            Program p1 = new Program(100);
            p1.btps();
            Console.ReadKey();
        }
    }
}
