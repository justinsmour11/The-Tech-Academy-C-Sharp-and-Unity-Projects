using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", ID=1 };
            //employee1.SayName();
            //Employee employee2 = new Employee() { FirstName = "Justin", LastName = "Seymour", ID = 1 };

            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "Justin", "Bob", "Tonya" };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 31, 45, 37 };

            foreach(string name in employee1.Things)
            {
                Console.WriteLine(name);
            }
            foreach(int age in employee2.Things)
            {
                Console.WriteLine(age);
            }
            Console.ReadLine();
            
        }
    }
}
