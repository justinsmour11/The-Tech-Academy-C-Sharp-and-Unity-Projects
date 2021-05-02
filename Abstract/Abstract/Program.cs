using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student", EmpID = 8 };
            //employee.SayName();
            //Console.ReadLine();

            //Employee employee2 = new Employee() { firstName = "Ted", lastName = "Bundy", EmpID = 7 };

            //IQuittable quit = new Employee() { firstName = "Justin", lastName = "Seymour", EmpID = 2 };
            //quit.Quit();
            //Console.ReadLine();

            //if (employee == employee2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //Console.ReadLine();

            Employee<string> employeeStr = new Employee<string>();
            employeeStr.things = new List<string>() { "Soap", "Bread", "TV", "Debra" };

            Employee<int> employeeInt = new Employee<int>();
            employeeInt.things = new List<int>() { 3, 8, 90, 45 };

            foreach (var thing in employeeStr.things)
            {
                Console.WriteLine(thing);
            }
           foreach (var thing in employeeInt.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
