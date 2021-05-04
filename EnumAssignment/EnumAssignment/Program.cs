using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            week.DayOfWeek = new List<DayOfWeek>();
                        
            for (int i = 0; i < 7; i++)
            {
                week.DayOfWeek.Add((DayOfWeek)i);
            }
            
            Console.WriteLine("Please enter a day of the week");
            string userInput = Console.ReadLine();

            try
            {
                DayOfWeek userDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput);
                
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            

            Console.ReadLine();
        }
    }
    
}
