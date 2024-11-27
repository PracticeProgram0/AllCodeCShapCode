using System;


namespace Userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a Number A..");
             a=int.Parse( Console.ReadLine());
            Console.WriteLine("Enter a no  B..");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum is " + c);
            Console.ReadKey();
        
        }
    }
}
