using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userInput = 25;
            decimal userDecimal = 45.00m;
            string userString = "9";

            Functions function = new Functions();
            function.userInput = userInput;
            function.userDecimal = userDecimal;





            Console.WriteLine(function.Function(userInput));
            Console.WriteLine(function.Function(userDecimal));
            Console.WriteLine(function.Function(userString));
            Console.ReadLine();
        }
    }
}
