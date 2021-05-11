using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please enter a number");
            int hoursFromNow = Convert.ToInt32(Console.ReadLine());
            TimeSpan duration =  new TimeSpan(0, hoursFromNow,0, 0);
            DateTime answer = now.Add(duration);
            Console.WriteLine("In {0} hours, it will be {1}", hoursFromNow, answer); ;
            Console.ReadLine();

        }
    }
}
