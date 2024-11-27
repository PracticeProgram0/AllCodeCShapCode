using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        int a = 10;
        int b = 20;


        int c = a + b;
    }
    static void Main(String[]ar)
    {
        Program obj = new Program();
        Console.WriteLine(obj.c);
    }
}