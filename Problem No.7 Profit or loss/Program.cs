using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._7_Profit_or_loss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Product cost: ");
            int cost = int.Parse(Console.ReadLine());
            Console.Write("Market price is: ");
            int sell = int.Parse(Console.ReadLine());

            if (sell > cost)
            {
                Console.WriteLine("The product gains {0:C2} profit.", sell - cost);
            }
            else if (sell < cost)
            {
                Console.WriteLine("The product has {0:C2} loss.", cost - sell);
            }
            else
            {
                Console.WriteLine("Zero profit or loss.");
            }

            Console.ReadLine();
        }
    }
}
