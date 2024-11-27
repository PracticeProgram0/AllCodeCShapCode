using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            while (k <= 6)
            {
                int i = 7;
                while(i>=1)
                {
                    Console.Write(i);
                    i--;
                }  
                Console.WriteLine(); 
                k++;    
            }
            Console.ReadKey();
        }
    }
}
