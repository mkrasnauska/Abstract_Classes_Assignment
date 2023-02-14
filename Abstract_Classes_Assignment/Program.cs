using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee
            { FirstName = "Student", LastName = "Sample" };
            Employee.SayName();
            {
                Employee MyEmployee = new Employee();
                MyEmployee.Quit();


                Console.ReadLine();
            }
        }
    }
}
