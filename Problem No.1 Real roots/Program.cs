using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._1_Real_roots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter \"a\" coefficient (a != 0): ");
            int coefficientA = int.Parse(Console.ReadLine());
            Console.Write("Enter \"b\" coefficient: ");
            int coefficientB = int.Parse(Console.ReadLine());
            Console.Write("Enter \"c\" coefficient: ");
            int coefficientC = int.Parse(Console.ReadLine());
            int discriminant = ((coefficientB * coefficientB) - (4 * coefficientA * coefficientC));

            Console.WriteLine("Discriminant is: " + discriminant);
            if (discriminant > 0)
            {
                double xOne = (-coefficientB + Math.Sqrt((coefficientB * coefficientB) - (4 * coefficientA * coefficientC))) / (2 * coefficientA);
                double xTwo = (-coefficientB - Math.Sqrt((coefficientB * coefficientB) - (4 * coefficientA * coefficientC))) / (2 * coefficientA);
                Console.WriteLine("There are two real roots: x = {0} or x = {1}", xOne, xTwo);
            }
            else if (discriminant == 0)
            {
                double x = -(coefficientB / (2 * coefficientA));
                Console.Write("There is one real roots: x = {0}", x);
            }
            else
            {
                Console.WriteLine("No real roots.");
            }

            Console.ReadLine();
        }
    }
}
