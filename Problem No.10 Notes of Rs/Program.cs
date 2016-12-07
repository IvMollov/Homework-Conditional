using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._10_Notes_of_Rs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input amount: ");
            int amount = int.Parse(Console.ReadLine());
            int fiveHundred = 500;
            int oneHundred = 100;
            int fifty = 50;
            int twenty = 20;
            int ten = 10;
            int five = 5;
            int two = 2;
            int one = 1;
            int nu = ((int)amount / fiveHundred) / oneHundred;
            Console.WriteLine(nu);
            if ((int)(amount / fiveHundred) >= 1)
            {
                Console.WriteLine("500:{0}", (int)amount / fiveHundred);
                if ((((int)amount / fiveHundred) / oneHundred) > -1)
                {
                    Console.WriteLine("100:{0}", ((int)amount / fiveHundred) / oneHundred);
                }
                if (((int)amount / fiveHundred) > 0)
                {
                    Console.WriteLine("50:{0}", ((int)amount / fiveHundred));
                }
           
            }
            
            else if (((int)amount / oneHundred) > -1)
            {
                Console.WriteLine("100:{0}", (int)amount / oneHundred);
            }

        }
    }
}
