using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingMethods
{
    public class Functions
    {
        public Functions()
        {
            Console.WriteLine("It is working");
        }

        public int Function(int userInput)
        {
            int multAnswer = userInput * 50;
            return multAnswer;
        }

        

        public decimal Function(decimal userDecimal)
        {
            decimal multDec = userDecimal * 35;
            return multDec;
        }

        public int Function(string userString)
        {
            int strConvert = Convert.ToInt32(userString);
            int strConvertAnswer = strConvert + 100;
            return strConvertAnswer;
        }

        public int userInput { get; set; }
        public decimal userDecimal { get; set; }
        public string userString { get; set; }
    }
}
