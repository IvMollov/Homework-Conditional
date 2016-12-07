using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._3_Increase_append
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter \"1\" for integer, \"2\" for double or \"3\" for string input: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter integer variable: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine("You have entered: {0}", ++integer);
            }
            else if (choice == 2)
            {
                Console.Write("Enter double variable: ");
                double doubleVariable = double.Parse(Console.ReadLine());
                Console.WriteLine("You have entered: {0}", ++doubleVariable);
            }
            else if (choice == 3)
            {
                Console.Write("Enter string variable: ");
                string stringVariable = Console.ReadLine();
                stringVariable += "*";
                Console.WriteLine("You have entered: {0}", stringVariable);
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }

            Console.ReadLine();
        }
    }
}
