using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayPrimeNumbers
{
    class Program
    {
        #region Prime Numbers & Factors
        /*
         *
         * Prime numbers are numbers which are divisible by 1 and by itself.
         * Prime numbers are having 2 factors, 1 and by itself.
         * Facts about prime numbers :
         * 1. 0 and 1 are not considered prime numbers
         * 2. 2 is even prime number It is smallest prime number.
         *
         * Example : 2, 3, 5, 7, 11, 13, 17, 19, 23...
         */
        #endregion;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter desired Max number to display prime numbers ");

            int nMaxNumber = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Prime numbers between {0} and {1} are :", 2, nMaxNumber);

            bool isPrimeNumber = true;

            // outer for loop is responsible for checking the max number
            for (int i = 2; i <= nMaxNumber; i++)
            {
                // Inner for loop is responsible for checking the factors
                for (int j = 2; j <= nMaxNumber; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                if (isPrimeNumber)
                {
                    Console.WriteLine(i);
                }

                isPrimeNumber = true;
            }

            Console.ReadLine();
        }
    }
}
