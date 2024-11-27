using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class sampal
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)  
            {
                int j = i;
                while (j >= i)
                {
                    Console.Write(j);
                    j--;
                }

                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }


    }
}
