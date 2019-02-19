using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabuleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UnorderedNumbers = {30, 10, -90, -40, 50, 25, 70, -54, -80, 38};
            int nTemp = 0;

            Console.WriteLine("Sorted Numbers are : ");

            // Outer for loop is responsible for looping all #'s from the list
            for (int i = 0; i < UnorderedNumbers.Length; i++)
            {   
                // Inner for loop is responsible for finding lowest number
                for (int j = i + 1; j < UnorderedNumbers.Length; j++)
                {
                    // Check for lowest # and then swap
                    if(UnorderedNumbers[i] > UnorderedNumbers [j])
                    {
                        // simple switch logic
                        nTemp = UnorderedNumbers[j];
                        UnorderedNumbers[j] = UnorderedNumbers[i];
                        UnorderedNumbers[i] = nTemp;
                    }
                }

                Console.WriteLine(UnorderedNumbers[i]);

            }

            Console.ReadLine();
        }
    }
}
