using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    public class Program
    {
        static void Main()
        {
            Functions function = new Functions();

            Console.WriteLine("Please enter a number to perform math on");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter another number (this is optional)");
            int inputTwo;

            if(int.TryParse(Console.ReadLine(), out inputTwo))
            {
                Console.WriteLine(function.Function(inputOne, inputTwo));
            }
            else
            {
                Console.WriteLine(function.Function(inputOne));
            }


            Console.ReadLine();
        }
    }
}
