using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        int a;
        static int b=20;
        const int c =30;
       // readonly d;
      
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(b);
             Console.WriteLine(c);

            Program t = new Program();
            t.a = 10;
                    Console.WriteLine(t.a);
            Console.ReadKey(); 
        }
    }
}
