using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();
        }

        static int Cube(int num) // can return any values
        {
            int result = num * num * num;
            return result;
        }
    }
}
