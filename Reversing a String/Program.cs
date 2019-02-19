﻿using System;

namespace Reversing_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reversing a String
            string str = "Quackable is Awsome!";

            string reversed = reverse(str);
            string temp = "";
            foreach (string s in reversed.Split(' '))
            {
                temp += reverse(s) + ' ';
            }

            Console.WriteLine(reverse(temp));
            Console.ReadLine();
        }

        private static string reverse(string str)
        {
            char[] chars = str.ToCharArray();

            int j = chars.Length - 1;
            for (int i = 0; i < chars.Length / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                j--;
            }

            return new String(chars);
        }
    }
}
