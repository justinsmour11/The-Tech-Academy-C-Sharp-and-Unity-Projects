using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOpAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly rate?");
            string person1RateInput = Console.ReadLine();
            int person1Rate = Convert.ToInt32(person1RateInput);
            Console.WriteLine("Hours worked per week?");
            string person1HoursInput = Console.ReadLine();
            int person1Hours = Convert.ToInt32(person1HoursInput);
            int person1Salary = person1Rate * person1Hours * 52; 

            Console.WriteLine("Person 2\nHourly rate?");
            string person2RateInput = Console.ReadLine();
            int person2Rate = Convert.ToInt32(person2RateInput);
            Console.WriteLine("Hours worked per week?");
            string person2HoursInput = Console.ReadLine();
            int person2Hours = Convert.ToInt32(person2HoursInput);
            int person2Salary = person2Rate * person2Hours * 52;

            bool comparePersons = person1Salary > person2Salary;

            Console.WriteLine("Annual salary of Person 1:\n" + person1Salary);

            Console.WriteLine("Annual salary of Person 2:\n" + person2Salary);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + comparePersons);
            Console.ReadLine();
        }

    }
}
