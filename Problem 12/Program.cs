using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    class Program
    {
        const string HUNDREDS = "Hundred";
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int number = 0;
            if(!int.TryParse(value, out number))
            {
                Console.WriteLine("Not a Number!");

            }
            else
            {
                string[] digits = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                string[] tens = new string[] { "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                string[] exceptionNumbers = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                if (number == 0)
                {
                    Console.WriteLine("Zero");
                }

                List<int> numberDigits = new List<int>();

                for (; number != 0; number /= 10)
                {
                    int digit = number % 10;
                    numberDigits.Add(digit);
                }
                numberDigits.Reverse();

                int numberLength = numberDigits.Count;
                switch (numberLength)
                {
                    case 1:
                        Console.WriteLine(digits[numberDigits[0] + 1]);
                        break;
                    case 2:
                        if(numberDigits[1] == 1)
                        {
                            Console.WriteLine(exceptionNumbers[numberDigits[1]]);
                        }
                        else
                        {
                            Console.WriteLine(tens[numberDigits[0]] + " " + digits[numberDigits[1]]);
                        }
                        break;
                    case 3:

                }

            }
        }
    }
}
