using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Functions
    {
        public static int Multiply(int userInput)
        {
            int multAnswer = userInput * 4;
            return multAnswer;
        }
        public static int Divide(int userInput)
        {
            int divisionAnswer = userInput / 2;
            return divisionAnswer;
        }
        public static int Fraction(int userInput)
        {
            int fractionAnswer = userInput % 10;
            return fractionAnswer;
        }
    }
}
