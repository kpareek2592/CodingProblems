using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Palindrome
{
    public static class Palindrome1
    {
        public static bool IsPalindrome(string str)
        {
            var revStr = str.ToCharArray().Reverse();
            var rev = string.Join("", revStr);
            return str.ToLower() == rev.ToLower();
        }
    }
}
