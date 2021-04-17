using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value to perform math on: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int multiply = Functions.Multiply(userInput);
            int divide = Functions.Divide(userInput);
            int fraction = Functions.Fraction(userInput);
            Console.WriteLine("Your number times 4 equals: " + multiply);
            Console.ReadLine();
            Console.WriteLine("Your number divided by 2 equals: " + divide);
            Console.ReadLine();
            Console.WriteLine("The remainder after your number is divided by 10 is: "  + fraction);
            Console.ReadLine();
        }
    }
}
