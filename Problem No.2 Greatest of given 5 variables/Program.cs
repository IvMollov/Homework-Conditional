using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._2_Greatest_of_given_5_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter number 3: ");
            int numberThree = int.Parse(Console.ReadLine());
            Console.Write("Enter number 4: ");
            int numberFour = int.Parse(Console.ReadLine());
            Console.Write("Enter number 5: ");
            int numberFive = int.Parse(Console.ReadLine());

            if ((numberOne > numberTwo) && (numberOne > numberThree) && (numberOne > numberFour) && (numberOne > numberFive))
            {
                Console.Write(numberOne + " is greatest.");
            }
            else if ((numberTwo > numberOne) && (numberTwo > numberThree) && (numberTwo > numberFour) && (numberTwo > numberFive))
            {
                Console.Write(numberTwo + " is greatest.");
            }
            else if ((numberThree > numberOne) && (numberThree > numberTwo) && (numberThree > numberFour) && (numberThree > numberFive))
            {
                Console.Write(numberThree + " is greatest.");
            }
            else if ((numberFour > numberOne) && (numberFour > numberTwo) && (numberFour > numberThree) && (numberFour > numberFive))
            {
                Console.Write(numberFour + " is greatest.");
            }
            else if ((numberFive > numberOne) && (numberFive > numberTwo) && (numberFive > numberThree) && (numberFive > numberFour))
            {
                Console.Write(numberFive + " is greatest.");
            }
            else
            {
                Console.Write("There is no greatest number.");
            }

            Console.ReadLine();
        }
    }
}
