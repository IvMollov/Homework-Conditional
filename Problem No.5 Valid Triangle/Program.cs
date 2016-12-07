using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._5_Valid_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first angle: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second angle: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third angle: ");
            int third = int.Parse(Console.ReadLine());
            int sum = first + second + third;

            if (sum == 180)
            {
                Console.WriteLine("Triangle is valid!");
            }
            else
            {
                Console.WriteLine("Triangle is not valid!");
            }

            Console.ReadLine();
        }
    }
}