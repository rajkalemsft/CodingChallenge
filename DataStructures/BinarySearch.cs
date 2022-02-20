using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal static class BinarySearch<T> where T : IComparable<T>
    {
        internal static T Search(T[] input, T valueToSearch)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            if (input.Length == 0)
            {
                return default(T);
            }

            return SearchArray(input, valueToSearch);
        }

        internal static T SearchArrayRecursion(T[] input, T valueToSearch)
        {
            if(input == null)
            {
                throw new ArgumentNullException("input");
            }
            if(input.Length == 0)
            {
                return default(T);
            }

            return SearchArrayRecursion(input, valueToSearch, 0, input.Length - 1);
        }

        /*
         * Example 1:  []
         * Example 1:  [1]
         * Example 1:  [1,2]
         * Example 1:  [1,2,3]
         * Example 1:  [1,2,3,4]
         */
        private static T SearchArray(T[] input, T valueToSearch)
        {
            var startIndex = 0;
            var endIndex = input.Length - 1;

            while(startIndex <= endIndex)
            {
                var midPointIndex = (endIndex - startIndex) / 2 +startIndex;
                if (input[midPointIndex].Equals(valueToSearch))
                {
                    return (T)input[midPointIndex];
                }
                else if (input[midPointIndex].CompareTo(valueToSearch) < 0)
                {
                    startIndex = midPointIndex + 1;
                }
                else if (input[midPointIndex].CompareTo(valueToSearch) > 0)
                {
                    endIndex = midPointIndex - 1;
                }
            }
            return default(T);
        }


        /*
         * Example 1:  []
         * Example 1:  [1]
         * Example 1:  [1,2]
         * Example 1:  [1,2,3]
         * Example 1:  [1,2,3,4]
         */
        private static T SearchArrayRecursion(T[] input,T valueToSearch, int searchStartIndex, int searchEndIndex)
        {
            if (searchStartIndex == searchEndIndex)
            {
                if (input[searchStartIndex].Equals(valueToSearch))
                {
                    return input[searchStartIndex];
                }
                else
                {
                    //Throw an Exception - Item not found
                    return default;
                }
            }
           
            var midPointIndex = (searchEndIndex - searchStartIndex) / 2 +searchStartIndex;

            if (input[midPointIndex].Equals(valueToSearch))
            {
                return (T)input[midPointIndex];
            }
            else if(input[midPointIndex].CompareTo(valueToSearch) < 0)
            {
                return SearchArrayRecursion(input, valueToSearch, midPointIndex + 1, searchEndIndex);
            }
            else if(input[midPointIndex].CompareTo(valueToSearch) > 0)
            {
                return SearchArrayRecursion(input, valueToSearch, searchStartIndex, midPointIndex-1);
            }
            
            return default(T);
        }
    }
}
