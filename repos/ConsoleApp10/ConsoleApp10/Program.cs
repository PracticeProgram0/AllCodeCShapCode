using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = int.Parse(Console.ReadLine());         
                do
                {
                i++;
               
                    Console.WriteLine(i);
                }
                while (i < j);
            Console.ReadKey();

        }
    }
    }


