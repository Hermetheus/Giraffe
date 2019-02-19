using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSourceNumber, nReverseNumber = 0;

            Console.Write("Please enter the number which you would like to reverse : ");

            nSourceNumber = int.Parse(Console.ReadLine());

            while (nSourceNumber != 0)
            {
                nReverseNumber = nReverseNumber * 10;
                nReverseNumber = nReverseNumber + nSourceNumber % 10;
                nSourceNumber = nSourceNumber / 10;
            }

            Console.WriteLine("The reverse number is {0}", nReverseNumber);

            Console.ReadLine();
        }
    }
}
