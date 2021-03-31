using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nWhat is the package weight?");
            //int packageWeigtht = Convert.ToInt32(Console.ReadLine());
            //if (packageWeigtht > 50)
            //{
            //    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("What is the package width?");
            //    int packWidth = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("What is the package height?");
            //    int packHeight = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("What is the package length?");
            //    int packLength = Convert.ToInt32(Console.ReadLine());
            //    int packDimensions = packWidth + packHeight + packLength;
            //    if (packDimensions > 50)
            //    {
            //        Console.WriteLine("Package too big to be shipped via Package Express.");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        int packQuote = packWidth * packHeight * packLength * packageWeigtht / 100;
            //        decimal packPrice = Convert.ToDecimal(packQuote);
            //        Console.WriteLine("Your estimated total for shipping this package is:\n$" + packPrice + ".00\nThank you!");
            //        Console.ReadLine();
            //    }
            //}

            int rating = 11;
            switch (rating)
            {
                case 1:
                    Console.WriteLine("That's awful!");
                    break;
                case 10:
                    Console.WriteLine("That's perfect!");
                    break;

                case 16:
                    Console.WriteLine("You wrote greg");
                    break;
                default:
                    Console.WriteLine("what");
                    break;
            }
            Console.ReadLine();

        }
    }
}
