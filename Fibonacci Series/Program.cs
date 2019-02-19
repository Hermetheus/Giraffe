using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fibonacci Series
             *
             * it is a series of numbers in which each number is the sum of the two preceding numbers
             *
             * Example :
             *
             * 0, 1, 1, 2, 3, 5, 8
             *
             */

            int number, previousNumber = -1, nextNumber = 1;

            Console.WriteLine("Please enter the number which you would like to fibonacci series.");

            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series");

            for (int i = 0; i<number; i++)
            {
                int sumNumber = previousNumber + nextNumber;
                Console.WriteLine(sumNumber);
                previousNumber = nextNumber;
                nextNumber = sumNumber;
            }

            Console.ReadLine();
        }
    }
}
