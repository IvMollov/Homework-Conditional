using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._8_Gross_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter basic salary (10 000 >=): ");
            int basic = int.Parse(Console.ReadLine());
            double HRA, DA;
            double gross = 0;

            if ((basic >= 10000) && (basic < 20000))
            {
                HRA = (basic * 20) / 100;
                DA = (basic * 80) / 100;
                gross = basic + HRA + DA;
                Console.WriteLine("Gross salary is: {0}", gross);
            }
            else if ((basic >= 20000) && (basic < 30000))
            {
                HRA = (basic * 25) / 100;
                DA = (basic * 90) / 100;
                gross = basic + HRA + DA;
                Console.WriteLine("Gross salary is: {0}", gross);
            }
            else if ((basic >= 30000))
            {
                HRA = (basic * 30) / 100;
                DA = (basic * 95) / 100;
                gross = basic + HRA + DA;
                Console.WriteLine("Gross salary is: {0}", gross);
            }
            else
            {
                Console.WriteLine("Incorrect salary.");
            }

            Console.ReadLine();
        }
    }
}
