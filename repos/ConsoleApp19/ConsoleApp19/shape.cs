using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    abstract class Shape
    {
        abstract public void area();
    }


    class circle : Shape
    {
        int r;
        public circle(int r)
        {

            this.r = r;
            Console.WriteLine(r);
        }
        public override void area()
        {
            double a = 3.14 * r * r;
            Console.WriteLine("area is " + a);
        }
        public circle()
        {
            double c = 2 * 3.14 * r;
            Console.WriteLine("double is" + c);
        }
    }
        class Rect : circle
        {
            int l;
            int b;
            public Rect(int l, int b)
            {
                this.l = l;
                this.b = b;
            }
            public override void area()
            {
                int a = l + b;
                Console.WriteLine(a);
            }
            public void peri()
            {
                int p = 2 * (l + b);
                Console.WriteLine(p);
            }
        }
    }


            
     
         
    

