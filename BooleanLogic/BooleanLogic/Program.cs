using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find out if you qualify for car insurance!\nWhat is your age?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            Console.WriteLine("Have you ever had a DUI? (Please answer true or false)");
            string duiInput = Console.ReadLine();
            bool DUI = Convert.ToBoolean(duiInput);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine();
            int ticketsNum = Convert.ToInt32(ticketsInput);
            bool isQualified = (age > 15 && DUI == false && ticketsNum <= 3);
            Console.WriteLine("Qualified?\n" + isQualified);
            Console.ReadLine();


        }
    }
}
