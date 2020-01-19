using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleApp1.Palindrome;
using ConsoleApp1.ReverseString;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Reverse
            //Console.WriteLine(RS1.ReverseString("Apple"));
            //Console.WriteLine(RS2.ReverseString("Mango"));

            // Palindrome
            //Console.WriteLine(Palindrome1.IsPalindrome("JAHAJ"));
            Console.WriteLine(Palindrome2.IsPalindrome("JAHAJI"));
            Console.ReadLine();
        }
    }
}
