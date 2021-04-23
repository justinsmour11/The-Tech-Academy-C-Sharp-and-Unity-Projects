using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions function = new Functions();
            function.Function(2, 70, out int mathOne);
            Console.WriteLine(mathOne);
            Console.ReadLine();
            int inputOne = 4;
            int inputTwo = 80;
            function.Function(inputOne, inputTwo, out mathOne);
            Console.WriteLine(mathOne);
            Console.ReadLine();
        }
    }
}
