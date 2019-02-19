using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSource = "";
            int nCount = 0;

            Console.Write("Please enter the string : ");
            strSource = Console.ReadLine();

            foreach (char c in strSource)
            {
                nCount = nCount + 1;
            }

            Console.WriteLine("{0} length is {1} ", strSource, nCount.ToString());
            Console.ReadLine();
        }
    }
}
