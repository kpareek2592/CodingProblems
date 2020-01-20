using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.ReverseNumber
{
    public static class ReverseNum
    {
        public static int NumReverse(int num)
        {
            var numAsString = num.ToString().ToCharArray();
            var revNum = numAsString.Reverse();
            var rev1 = string.Join("", revNum);
            var rev = Int32.Parse(rev1) * Math.Sign(num);
            
            return rev;
        }
    }
}
