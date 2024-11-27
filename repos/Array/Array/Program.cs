using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* string fullname = "btps training center";
             string shortname = "btps";
             string totalname = fullname +"  " +shortname;
             Console.WriteLine(totalname);*/
            int[] array = { 1, 2, 3, 4, 5 };
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;



            Console.WriteLine(array[2]);








            /*int a=1; int b=2;
            int sum = a + b;
            int mul=a*b;
            int sub = a - b;
            Console.WriteLine("sum={0}\n mul={1}\n sub={2}",sum,mul,sub);
            Console.WriteLine($"sum={sum} mul={mul} sub={sub}"); 
            */
            Console.ReadKey();

            //Console.WriteLine( "main class");
           // run();

          //  Program a = new Program();
           // a.ram();
           // a.btps();

            //a.add();

        }
        static void run()
        {
            Console.WriteLine("This is a static method");
        }
        void ram()
        {
            Console.WriteLine("non static method");

        }
        void btps()
        {
            Console.WriteLine("btps method is calling");
        }
        void add()
        {
            Console.WriteLine("constratur is calling");
        }
    }
}
