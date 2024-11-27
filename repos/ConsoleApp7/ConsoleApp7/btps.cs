using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class btps
    {
        static void Main(string[] ar)
        {

            int age, bj=0, cn=0, sp=0 ,nota=0,e=0;
            while (true)
            {

                Console.WriteLine("Enter age..");
                age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("Welcome to online voting System");
                    Console.WriteLine("Prese 1 for BJP\n Prese 2 for Congres\nPrese 3 for sapa");
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                    {
                        //Console.WriteLine("vote for BJP");
                        bj++;
                        e++;
                    }
                    else if (opt == 2)
                    {
                        //Console.WriteLine("vote for congres");
                        cn++;
                        e++;
                    }
                    else if (opt == 3)
                    {
                        // Console.WriteLine("vote for sapa");
                        sp++;
                        e++;
                    }
                    else
                    {
                        // Console.WriteLine("nata..");
                        nota++;
                        e++;
                    }                

                }// if closing tab
                else
                {
                    Console.WriteLine("not elegable for vote");
                }
                if (e == 2)                
                    break;            
            }// while closing 
            Console.WriteLine("total vote BJP" + "" + bj);
            Console.WriteLine("total vote Congrece" + "" + cn);
            Console.WriteLine("total vote Sapa" + "" + sp);
            Console.WriteLine("total vote NOTA" + "" + nota);
            Console.ReadKey();
        }
    }
}
