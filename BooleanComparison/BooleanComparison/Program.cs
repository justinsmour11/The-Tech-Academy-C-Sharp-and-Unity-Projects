using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());
            bool boolVal = false;

            while(number < 3)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Keep guessing higher");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You're almost there!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1 and it's not correct");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("2 is incorrect");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Nice job! Now keep guessing!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("You guessed the highest number!");
                        boolVal = true;
                        break;
                    default:
                        Console.WriteLine("You keep guessing the wrong numbers...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!boolVal);
            Console.ReadLine();
        }
    }
}
