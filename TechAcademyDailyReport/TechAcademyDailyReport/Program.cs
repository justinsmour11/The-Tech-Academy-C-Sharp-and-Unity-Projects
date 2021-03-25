using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything? (Please answer true or false)");
            string help = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursNum = Convert.ToInt32(hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
