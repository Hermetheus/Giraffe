using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Factorial means to multiply a series of descending natural numbers.
             *
             * Fact : Zero factoril is 1
             *
             * Examples are :
             *
             * 1 factorial = 1 * 1 = 1
             * 2 = 2 * 1 = 2
             * 3 = 3 * 2 * 1 = 6
             * etc
             */

            int number, factorial = 1, i;

            Console.Write("Please enter the number to calculate the factorial :");
            number = int.Parse(Console.ReadLine());

            if(number < 0)
            {
                Console.WriteLine("Factorials are not applicable for negative numbers");
            }
            else if(number == 0)
            {
                Console.WriteLine("Zero factorial is 1");
            }
            else
            {
                for(i = number; i >= 1; i--)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine("{0} has a factorial of {1}", number.ToString(), factorial.ToString());
            }

            Console.ReadLine();
        }
    }
}
