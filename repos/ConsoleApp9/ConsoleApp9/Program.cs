using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = int.Parse(Console.ReadLine());
            for (int a = 1; a <= i; a++)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
