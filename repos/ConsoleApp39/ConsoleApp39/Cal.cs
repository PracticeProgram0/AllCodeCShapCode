using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Cal
    {
        int a, b, c;
       public int A_val
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
            public int B_val
         {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
         } 
            public void add()
            {
            c = a + b;
            Console.WriteLine(c);
      
            }
     }

    }

