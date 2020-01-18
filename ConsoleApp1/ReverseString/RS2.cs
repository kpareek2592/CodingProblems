using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ReverseString
{
    public static class RS2
    {
        public static string ReverseString(string str)
        {
            string reversed = string.Empty;
            foreach (var character in str)
            {
                reversed = character + reversed;
            }
            return reversed;
        }
    }
}
