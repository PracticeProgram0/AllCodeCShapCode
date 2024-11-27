using System;
using System.Threading;


namespace ConsoleApp3
{
    internal class Program
    {
         void tab() {
            Console.WriteLine("Enter a no");
            int m = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i <= m; i++)
            {             

                if (i % 2 == 0)
                {
                    Console.WriteLine("This is a Even no"+i);
                    even =i++;
                }
                else
                {
                    Console.WriteLine("This is a odd no" + i);
                    odd = i++;
                    Console.WriteLine(odd);

                }
            }
           // Console.WriteLine(even);
           // Console.WriteLine(odd);

        }

        static void Main(string[] args)
        {
            Program a = new Program();
            a.tab();
            
            Console.ReadKey();

        }
    }
}
