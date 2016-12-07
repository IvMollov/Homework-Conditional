using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._4_Zero_subset
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
            if ((numberOne + numberTwo) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberOne, numberTwo);
            }
            else if ((numberOne + numberThree) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberOne, numberThree);
            }
            else if ((numberOne + numberFour) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberOne, numberFour);
            }
            else if ((numberOne + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberOne, numberFive);
            }
            else if ((numberTwo + numberThree) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberTwo, numberThree);
            }
            else if ((numberTwo + numberFour) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberTwo, numberFour);
            }
            else if ((numberTwo + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberTwo, numberFive);
            }
            else if ((numberThree + numberFour) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberThree, numberFour);
            }
            else if ((numberThree + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberThree, numberFive);
            }
            else if ((numberFour + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numberFour, numberFive);
            }
            else if ((numberOne + numberTwo + numberThree) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberOne, numberTwo, numberThree);
            }
            else if ((numberOne + numberTwo + numberFour) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberOne, numberTwo, numberFour);
            }
            else if ((numberOne + numberTwo + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberOne, numberTwo, numberFive);
            }
            else if ((numberOne + numberThree + numberFour) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberOne, numberThree, numberFour);
            }
            else if ((numberOne + numberThree + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberOne, numberThree, numberFive);
            }
            else if ((numberOne + numberFour + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberOne, numberFour, numberFive);
            }
            else if ((numberTwo + numberThree + numberFour) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberTwo, numberThree, numberFour);
            }
            else if ((numberTwo + numberFour + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberTwo, numberFour, numberFive);
            }
            else if ((numberThree + numberFour + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numberThree, numberFour, numberFive);
            }
            else if ((numberOne + numberTwo + numberThree + numberFour) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numberOne, numberTwo, numberThree, numberFour);
            }
            else if ((numberOne + numberTwo + numberThree + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numberOne, numberTwo, numberThree, numberFive);
            }
            else if ((numberTwo + numberThree + numberFour + numberFive) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numberTwo, numberThree, numberFour, numberFive);
            }
            else
            {
                Console.WriteLine("There is no subset with 0 sum.");
            }

            Console.ReadLine();
        }
    }
}
