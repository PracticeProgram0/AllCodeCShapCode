using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class loop1
    {
        static void Main(string[] ar)
        {
            int a = 1;
            while (a <= 10)
            {
                int i = 1;
                while (i <= a)
                {


                    Console.WriteLine(i);
                    i++;
                }
                a++;

            }
            
            Console.ReadKey();
        }
    }
}