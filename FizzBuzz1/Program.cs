using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 100; j++)
            {
                string results = "";
                // If divisible by 3 - write "Fizz"
                if (j % 3 == 0) results = "Fizz";
                // If divisible by 5 - write "Buzz"
                if (j % 5 == 0) results = results + "Buzz";
                //print the number if not divisible by 3 or 5
                if (results.Length == 0) results = j.ToString();

                Console.WriteLine(results);
                Console.ReadLine();

            }
        }
    }
}
