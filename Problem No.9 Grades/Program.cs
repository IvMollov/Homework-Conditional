using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._9_Grades
{
    class Program
    {
        const double max = 30;

        static void Main(string[] args)
        {
            Console.Write("Enter Physics mark: ");
            double physics = double.Parse(Console.ReadLine());
            Console.Write("Enter Chemistry mark: ");
            double chemistry = double.Parse(Console.ReadLine());
            Console.Write("Enter Biology mark: ");
            double biology = double.Parse(Console.ReadLine());
            Console.Write("Enter Mathematics mark: ");
            double mathematics = double.Parse(Console.ReadLine());
            Console.Write("Enter Computer mark: ");
            double computer = double.Parse(Console.ReadLine());
            double sum = (physics + chemistry + biology + mathematics + computer) / max;

            if (sum >= 90)
            {
                Console.WriteLine("Your percentage is {0:P}, you get Grade A.", sum);
            }
            else if ((sum >= 0.80) && (sum < 0.90))
            {
                Console.WriteLine("Your percentage is {0:P}, you get Grade B.", sum);
            }
            else if ((sum >= 0.70) && (sum < 0.80))
            {
                Console.WriteLine("Your percentage is {0:P}, you get Grade C.", sum);
            }
            else if ((sum >= 0.60) && (sum < 0.70))
            {
                Console.WriteLine("Your percentage is {0:P}, you get Grade D.", sum);
            }
            else if ((sum >= 0.40) && (sum < 0.60))
            {
                Console.WriteLine("Your percentage is {0:P}, you get Grade E.", sum);
            }
            else
            {
                Console.WriteLine("Your percentage is {0:P}, you get Grade F.", sum);
            }

            Console.ReadLine();
        }
    }
}
