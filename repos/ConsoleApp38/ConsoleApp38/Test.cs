using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Test             // second page add kiya project pe
                                       // click then add + class name Test                                   
    {
        static void Main(string[] args)
        {
            Program obj=new Program();

            Console.WriteLine("public member" +obj.c);
            Console.WriteLine(" internal" + obj.e);
            Console.WriteLine(obj.f);

            Console.ReadKey();              
        }
    }
}
