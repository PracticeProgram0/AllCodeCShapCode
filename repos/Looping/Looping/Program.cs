using System;
class Program
    {   
        static void Main(String[] args)
        {
            int i = 1,n;
             n= int.Parse(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
            Console.Write(" ");
            for(int j=1;j<=5;j++)

                Console.Write(j);
             
                
            }
            Console.ReadKey();
        }
    }

