using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, nTemp;

            Console.Write("Please enter the first number : ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number : ");
            secondNumber = int.Parse(Console.ReadLine());

            nTemp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = nTemp;

            Console.WriteLine("After swapping the first number is {0} and second number is {1}", firstNumber, secondNumber);

            Console.ReadLine();
        }
    }
}
