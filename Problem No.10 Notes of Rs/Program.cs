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
            int fiveHundred;
            int oneHundred;
            int fifty;
            int twenty;
            int ten;
            int five;
            int two;
            int one;

            if (amount >= 500)
            {
                fiveHundred = amount / 500;
                amount -= (fiveHundred * 500);
                oneHundred = amount / 100;
                amount -= (oneHundred * 100);
                fifty = amount / 50;
                amount -= (fifty * 50);
                twenty = amount / 20;
                amount -= (twenty * 20);
                ten = amount / 10;
                amount -= (ten * 10);
                five = amount / 5;
                amount -= (five * 5);
                two = amount / 2;
                amount -= (two * 2);
                one = amount / 1;
                    
                Console.WriteLine("500:{0}", fiveHundred);
                Console.WriteLine("100:{0}", oneHundred);
                Console.WriteLine("50:{0}", fifty);
                Console.WriteLine("20:{0}", twenty);
                Console.WriteLine("10:{0}", ten);
                Console.WriteLine("5:{0}", five);
                Console.WriteLine("2:{0}", two);
                Console.WriteLine("1:{0}", one);
            }
            else if (amount < 500)
            {
                oneHundred = amount / 100;
                amount -= (oneHundred * 100);
                fifty = amount / 50;
                amount -= (fifty * 50);
                twenty = amount / 20;
                amount -= (twenty * 20);
                ten = amount / 10;
                amount -= (ten * 10);
                five = amount / 5;
                amount -= (five * 5);
                two = amount / 2;
                amount -= (two * 2);
                one = amount / 1;

                Console.WriteLine("100:{0}", oneHundred);
                Console.WriteLine("50:{0}", fifty);
                Console.WriteLine("20:{0}", twenty);
                Console.WriteLine("10:{0}", ten);
                Console.WriteLine("5:{0}", five);
                Console.WriteLine("2:{0}", two);
                Console.WriteLine("1:{0}", one);
            }
          
        }
    }
}
