using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    public class Functions
    {
        public void Function(int inputOne, out int outputOne)
        {
            outputOne = inputOne / 2;
        }

        public int Function(int inputOne)
        {
            int myOutput = inputOne * 45;
            return myOutput;
        }
    }
}
