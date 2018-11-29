using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Methods_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulTools.SayHi("Allan");

            Console.WriteLine(Math.Sqrt(144)); //don't need to create object for static Methods.



            Console.ReadLine();
        }
    }
}
