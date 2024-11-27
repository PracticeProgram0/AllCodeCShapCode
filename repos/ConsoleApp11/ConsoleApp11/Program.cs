using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = int.Parse(Console.ReadLine());
            while(i<=n)
            {
                if(i%2!=0)

                Console.WriteLine(i);
                i++;
            }
           
            Console.ReadKey(); 
        }
    }
}
