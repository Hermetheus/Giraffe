﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++) //3 Conditions
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
