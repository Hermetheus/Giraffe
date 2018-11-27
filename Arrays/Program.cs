using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Berry";

            luckyNumbers[1] = 900; //chooose the variable to change

            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}
