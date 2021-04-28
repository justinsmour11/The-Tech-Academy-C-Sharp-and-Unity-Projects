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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", EmpID = 8 };
            employee.SayName();
            Console.ReadLine();

            Employee employee2 = new Employee() { firstName = "Ted", lastName = "Bundy", EmpID = 7 };

            IQuittable quit = new Employee() { firstName = "Justin", lastName = "Seymour", EmpID = 2 };
            quit.Quit();
            Console.ReadLine();

            if (employee == employee2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();

           
        }
    }
}
