using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            int n, sum = 0, even = 0, od = 0;
            //            do
            //            {
            //                Console.WriteLine("Enter a Number");
            //                n = int.Parse(Console.ReadLine());
            //                sum = sum + n;
            //                if (n % 2 == 0)
            //                {
            //                    even = even + n;
            //                }
            //                else
            //                {

            //                }
            //                   // Odd = Od + n;
            //            }
            //            while (n != 0);

            //            Console.WriteLine("sum of all Number" + sum);
            //           // Console.WriteLine("sum of all add" + odd);
            //            Console.WriteLine("sum of all even" + even);
            //            Console.ReadKey();
            //        }
            //   }
            //}

            //GENERATE A RANDOM VALUE BETWEEN 1 AND 9
            //    int v = new Random().Next(1, 4);
            //    switch(v)
            //    {
            //        case 1: Console.WriteLine("Case-1");
            //            break;

            //            case 2: Console.WriteLine("case-2");
            //            break;

            //            case 3: Console.WriteLine("case-3");
            //            break;

            //           // case 4: Console.WriteLine("case-4");
            //           // break;

            //            default: Console.WriteLine("value did not match");
            //            break;

            //    }
            //    Console.ReadKey();
            //}
            int a = 10;
            do
            {
                Console.WriteLine("Ram");
                a++;
            }
            while (a<=10);

            Console.ReadKey();
        }
        
    }
}