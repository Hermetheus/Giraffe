using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Allan's Academy" + " is cool!";

            Console.WriteLine("Allan's/nLearning");

            Console.WriteLine("Allan's\"Learning");

            Console.WriteLine(phrase); //prints string

            Console.WriteLine(phrase.Length); //Length of string

            Console.WriteLine(phrase.ToUpper()); //Upper Case

            Console.WriteLine(phrase.ToLower()); //Lower Case

            Console.WriteLine(phrase.Contains("Allan")); //Truuuueeeeeeee

            Console.WriteLine(phrase.Contains("Potatoe")); //Doesn't contain potatoe

            Console.WriteLine(phrase[0]); // Prints "A"

            Console.WriteLine(phrase.IndexOf("Academy")); //starts at 8!

            Console.WriteLine(phrase.IndexOf("z")); //Shows -1 if it doesn't exist

            Console.WriteLine(phrase.Substring(8)); // Just grabs "Academy" it only grabs from 8 and beyond.

            Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy")));







            Console.ReadLine();
        }
    }
}
