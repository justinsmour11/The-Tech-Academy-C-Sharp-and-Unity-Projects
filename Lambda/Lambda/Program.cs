using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Johnson",
                ID = 1
            };
            Employee emp2 = new Employee()
            {
                FirstName = "John",
                LastName = "Stevens",
                ID = 2
            };
            Employee emp3 = new Employee()
            {
                FirstName = "Bob",
                LastName = "Williams",
                ID = 3
            };
            Employee emp4 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Henry",
                ID = 4
            };
            Employee emp5 = new Employee()
            {
                FirstName = "Ahmed",
                LastName = "Sanders",
                ID = 5
            };
            Employee emp6 = new Employee()
            {
                FirstName = "Bill",
                LastName = "Johnson",
                ID = 6
            };
            Employee emp7 = new Employee()
            {
                FirstName = "Karen",
                LastName = "Phillips",
                ID = 7
            };
            Employee emp8 = new Employee()
            {
                FirstName = "Cindy",
                LastName = "Sanchez",
                ID = 8
            };
            Employee emp9 = new Employee()
            {
                FirstName = "Gary",
                LastName = "Frank",
                ID = 9
            };
            Employee emp10 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Schuster",
                ID = 10
            };

            List<Employee> empList = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };

            List<Employee> newList = new List<Employee>();

            foreach (Employee emp in empList)
            {
                if (emp.FirstName == "Joe")
                {
                    newList.Add(emp);
                    Console.WriteLine(emp.FirstName + " " + emp.LastName);
                }

            }

            List<Employee> myList = empList.Where(x => x.FirstName == "Joe").ToList();

            foreach(Employee e in myList)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName);
            }

            List<Employee> idList = empList.Where(x => x.ID > 5).ToList();

            foreach(Employee i in idList)
            {
                Console.WriteLine("{0} {1}, with an ID of {2}", i.FirstName, i.LastName, i.ID);

            }


            Console.ReadLine();
        }
    }
}
