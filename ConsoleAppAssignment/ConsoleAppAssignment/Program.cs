using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            //Part 1
            string[] stringArray = { "Item 1: ", "Item 2: ", "Item 3: ", "Item 4: " };
            Console.WriteLine("Please enter some text");
            string strInput = Console.ReadLine();
            //appends user input to each item in array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + strInput;
            }
            //prints each item of array to separate line
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();

            //Part 2
            //infinite loop
            bool boolValue = true;
            //changing the boolValue to false prevents this from being an infinite loop
            while (boolValue)
            {
                Console.WriteLine("This was an infinite loop!");
                boolValue = false;
            }
            Console.ReadLine();

            //Part 3
            //using < operator
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            //using <= operator
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Part 4
            List<string> users = new List<string>()
            {
                "Justin", "Susan", "Bradley", "Jacob", "Diane"
            };
            Console.WriteLine("Search for a user to display their index!\nOptions are: Justin, Susan, Bradley, Jacob, and Diane");
            string userInput = Console.ReadLine();
            bool boolUserValue = users.Contains(userInput);
            if (boolUserValue)
            {
                foreach (string user in users)
                {
                    if (userInput == user)
                    {
                        Console.WriteLine(users.IndexOf(user));
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("That isn't on our list!");
            }

            Console.ReadLine();

            //Part 5
            List<string> colors = new List<string>()
            {
                "red", "pink", "green", "pink", "red", "black"
            };
            Console.WriteLine("Choose a color: red, pink, green, black");
            string userColor = Console.ReadLine();
            bool boolColorValue = colors.Contains(userColor);
            if (boolColorValue)
            {
                for (int i = 0; i < colors.Count; i++)
                {
                    if (userColor == colors[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("That's not in our list!");
            }
            Console.ReadLine();

            //Part 6
            List<string> makers = new List<string>()
            {
                "Justin", "Roger", "Tim", "Justin", "Tim", "Frank"
            };
            List<string> makersCopy = new List<string>();


            foreach (string maker in makers)
            {
                string makerOne = maker;
                foreach (string makerCopy in makersCopy)
                {

                    if (maker == makerCopy)
                    {
                        makerOne = makerCopy + " has appeared before";
                    }
                }
                makersCopy.Add(maker);
                Console.WriteLine(makerOne);
            }
            Console.ReadLine();
        }
    }
}
