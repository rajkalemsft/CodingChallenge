using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal static class StringOps
    {
        public static string ReverseString(string inStr)
        {
            /*
             * 1. Check if the the string is null or has empty spaces.
             * 2. Find the median
             * 3. loop through every character of the string until the median
             *    Iterator i starts at 0 and ends at median
             *    Calculate LastIndex = InStr.Length -1 - i
             *    Take inStr[i] into temp variable
             *    Place inStr[lastIndex] into inStr[i]
             */


            if (string.IsNullOrEmpty(inStr))
            {
                return inStr;
            }

            var median = inStr.Length / 2;
            var lastIndex = inStr.Length - 1;
            var charArray = inStr.ToCharArray();

            for (int i = 0; i < median; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[lastIndex - i];
                charArray[lastIndex - i] = temp;
            }


            return new string(charArray);
        }
    }
}
