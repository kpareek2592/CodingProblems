using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Palindrome
{
    public static class Palindrome2
    {
        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
