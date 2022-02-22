using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal static class Recursion
    {
        internal static int SumListItems(int[] input)
        {

            return SumListItem(input, input.Length);
        }

        private static int SumListItem(int[] input, int index)
        {
            index--;
            if (index < 0)
            {
                return 0;
            }
            else
            {
                return input[index] + SumListItem(input, index);
            }
        }

        internal static int CountNumberOfItemsInList(int[] input)
        {

            return NumberOfItemsInList(input, input.Length);
        }

        private static int NumberOfItemsInList(int[] input, int index)
        {
            index--;
            if (index < 0)
            {
                return 0;
            }
            else
            {
                return 1 + NumberOfItemsInList(input, index);
            }
        }

        internal static int MaximumNumberInList(int[] input)
        {
            if (input == null || input.Length == 0) {
                throw new ArgumentException("input");
            }

            return FindMaximumNumberInList(input, 0, input[0]);
        }

        private static int FindMaximumNumberInList(int[] input, int index, int maxNumber)
        {
            if(index == input.Length)
            {
                return maxNumber;
            }
            if(input[index] > maxNumber)
            {
                maxNumber = input[index];
            }

            return FindMaximumNumberInList(input, index + 1, maxNumber);
        }
    }
}
