using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Justin", "Fred", "John", "Sarah" };
        int[] intArray = { 5, 10, 60, 7, 45, 110 };

        Console.WriteLine("Please select a number between 0 and 3 to display a name");
        int stringInput = Convert.ToInt32(Console.ReadLine());
        if (stringInput >= 0 && stringInput < 4)
        {
            Console.WriteLine(stringArray[stringInput]);
        }
        else
        {
            Console.WriteLine("I'm sorry, that item doesn't exist");
        }

        Console.WriteLine("Please select a number between 0 and 5 to display a number");
        int intInput = Convert.ToInt32(Console.ReadLine());
        if(intInput > 5)
        {
            Console.WriteLine("That item doesn't exist");
        }
        else
        {
            Console.WriteLine(intArray[intInput]);

        }
        List<string> stringList = new List<string>()
        {
            "Red", "Green", "Blue", "Black"
        };
        Console.WriteLine("Select a number between 0 and 3 to display a color");
        int colorInput = Convert.ToInt32(Console.ReadLine());
        string colorAnswer = (colorInput > 3) ? "That item doesn't exist" : stringList[colorInput];
        Console.WriteLine(colorAnswer);
        Console.ReadLine();
    }
}

