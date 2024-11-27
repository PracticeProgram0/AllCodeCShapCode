using System;
using System.Collections.Generic;         
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        public int a=int.Parse(Console.ReadLine());
        public int b=int.Parse(Console.ReadLine());
              void m1()
        {
            int c = a + b;
            int d = c;
            Console.WriteLine("sum is"+ d);
        }
     
        static void Main(string[] args)
        {
            int age;
            age = int.Parse(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("you are voter");
            }
            else
            {
                Console.WriteLine("you are not voter");
            }
            int x = 1;
            for (x = 1; x <= 10; x++)
                Console.WriteLine(x);

            Program p1 = new Program();
            p1.m1();
            Console.ReadKey();
        }
    }
}
