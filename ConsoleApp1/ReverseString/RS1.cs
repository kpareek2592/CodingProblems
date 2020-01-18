using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ReverseString
{
    public static class RS1
    {
        // --- Directions
        // Given a string, return a new string with the reversed
        // order of characters
        // --- Examples
        //   reverse('apple') === 'leppa'
        //   reverse('hello') === 'olleh'
        //   reverse('Greetings!') === '!sgniteerG'

        public static string ReverseString(string str)
        {
            var arr = str.ToCharArray();
            var revArr = arr.Reverse();
            var a1 = string.Join("", revArr);
            return a1;
        }
    }
}
