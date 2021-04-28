﻿using System;
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
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            Console.ReadLine();

            IQuittable quit = new Employee() { firstName = "Justin", lastName = "Seymour" };
            quit.Quit();
            Console.ReadLine();

        }
    }
}
