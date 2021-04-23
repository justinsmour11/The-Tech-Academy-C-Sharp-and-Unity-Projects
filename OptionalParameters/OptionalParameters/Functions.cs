using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    public class Functions
    {
        public int Function(int inputOne, int inputTwo = 2)
        {
            int numAnswer = inputOne * inputTwo;
            return numAnswer;
        }
    }
}
