using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double numberTwo = double.Parse(Console.ReadLine());
            Console.Write("Enter \"+\" for add,\"-\" for subtract, \"*\" for multiply or \"/\" for divide: ");
            string operation = Console.ReadLine();

            Calculator(operation, numberOne, numberTwo);

        }
        public static void Calculator(string operation, double numberA, double numberB)
        {
            double result = 0;
            switch (operation)
            {
                case "+": result = numberA + numberB; Console.WriteLine("{0} {1} {2} = {3}", numberA, operation, numberB, result); break;
                case "-": result = numberA - numberB; Console.WriteLine("{0} {1} {2} = {3}", numberA, operation, numberB, result); break;
                case "*": result = numberA * numberB; Console.WriteLine("{0} {1} {2} = {3}", numberA, operation, numberB, result); break;
                case "/": result = numberA / numberB; Console.WriteLine("{0} {1} {2} = {3}", numberA, operation, numberB, result); break;
                default: Console.WriteLine("Incorrect operation!"); break;
            }
        }

    }
}
