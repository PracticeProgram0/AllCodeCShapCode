using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Class1
    {
        public class Employee
        {
         
            private int _EmpId;
            private string _EmpName;
            
            public int EmpId
            {
             
                set
                {
                    _EmpId = value;
                }
             
                get
                {
                    return _EmpId;
                }
            }
            public string EmpName
            {
                
                set
                {
                    _EmpName = value;
                }
               
                get
                {
                    return _EmpName;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee employee = new Employee();


                employee.EmpId = 101;
                employee.EmpName = "Pranaya";

                //Using public properties (Get Accessor) we are Getting 
                //the values of private data members
                Console.WriteLine("Employee Details:");
                Console.WriteLine("Employee id:" + employee.EmpId);
                Console.WriteLine("Employee name:" + employee.EmpName);
                Console.ReadKey();
            }
        }
    }
}

