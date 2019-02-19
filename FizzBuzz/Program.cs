using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 1 : Print number from 1 to 100

            for (int j = 1; j <= 100; j++)
            {
                string results = "";
                // step 2 : divisible by 3 print Fizz
                if (j % 3 == 0) results = "Fizz";
                // step 3 : divisible by 5 print Buzz
                if (j % 5 == 0) results = results + "Buzz";
                // step 5 : print number if it's not divisible by 3 or 5
                if (results.Length == 0) results = j.ToString();

                Console.WriteLine(results);
                Console.ReadLine();
            }
        }
    }
}
