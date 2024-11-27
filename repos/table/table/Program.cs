using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, rus, i, j;
            for (i = 0; i < 10; i++)
            {
                //Console.WriteLine(" Table of " +num);
                for (j = 1; j <= 1; j++)
                {
                    rus = num * j;
                    Console.WriteLine (rus );
                   // Console.WriteLine();
                }
                //Console.WriteLine();
                num++;
            }
            Console.ReadKey();
        }
    }
}
