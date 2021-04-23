using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Functions
    {
        public int mathOne { get; set; }

        public void Function(int inputOne, int inputTwo, out int mathOne)
        {
            mathOne = inputOne * 15;
            Console.WriteLine(inputTwo);
            Console.ReadLine();
        }
    }
}
