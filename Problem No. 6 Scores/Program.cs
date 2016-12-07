using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._6_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter scores in the range [1..9]: ");
            int score;
            string value = Console.ReadLine();
            if (!int.TryParse(value, out score))
            {
                Console.WriteLine("Not a value!");

            }
            else if ((score >= 1) && (score <= 3))
            {
                score *= 10;
                Console.WriteLine("Bonus x10. Scores are: {0}", score);
            }
            else if ((score >= 4) && (score <= 6))
            {
                score *= 100;
                Console.WriteLine("Bonus x100. Scores are: {0}", score);
            }
            else if ((score >= 7) && (score <= 9))
            {
                score *= 1000;
                Console.WriteLine("Bonus x1000. Scores are: {0}", score);
            }
            else
            {
                Console.WriteLine("You have entered invalid value");
            }

            Console.ReadLine();
        }
    }
}
