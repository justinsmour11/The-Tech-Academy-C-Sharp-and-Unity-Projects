using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions function = new Functions();
            Console.WriteLine("Please enter a number that will be halved.");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            int outputOne;

            function.Function(inputOne, out outputOne);

            Console.WriteLine(outputOne);
            Console.ReadLine();

            Console.WriteLine(function.Function(inputOne));
            Console.ReadLine();

            Console.WriteLine(StaticClass.Function(50));
            Console.ReadLine();
        }
    }
}
