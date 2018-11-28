using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_an_Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPower(3, 25));


            Console.ReadLine();
        }

        static int GetPower(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;
        }
    }
}
