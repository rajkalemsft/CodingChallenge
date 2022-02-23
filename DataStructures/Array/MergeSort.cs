using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal static class MergeSort
    {
        /* [8,3,22,9,33,2,5,23,21] 
         *  ==> [8,3,22,9,33] -> [8,3,22] -> [8,3] && [22] -> [8] [3] [22] -> [3,8,22] 
         *                    -> [9,33]  -> [9] [33] --> [9,33]
         *                    ==> [3,8,9,22,33]
         *  ==> [2,5,23,21] -> [2,5] && [23,21] -> [2] [5] -> [2,5]
         *                  -> [23,21] -> [23] [21] -> [21,23]
         *                  ==> [2,5,21,23]
         *                  
         *                  ==> [3,8,9,22,33] & [2,5,21,23] 
         *                  ==> [2,3,5,8,9,21,22,23,33] 
         *                  
         *  Logically divide the arrays into two sub-arrays (mid-way) and maintain the index range
         *  Invoke the Sort until the last element and then start merge
         *  Sort Method - Array, lowIndex, HighIndex
         *  Merge - Array, lowIndex, HighIndex
         *  
         * 
         * 
         * 
         */
        internal static void Sort(int[] input)
        {
            Sort(input, 0, input.Length -1);
        }

        private static void Sort(int[] input, int lowIndex, int highIndex)
        {
            var midPoint = (highIndex - lowIndex) / 2 + lowIndex;
            if(lowIndex < highIndex)
            {
                Sort(input, lowIndex, midPoint);
                Sort(input, midPoint +1, highIndex);
                Merge(input, lowIndex,midPoint, highIndex);
            }
        }

        private static void Merge(int[] input, int lowIndex, int mid, int highIndex)
        {
            //if mid+1 > mid return

            //
            for (int i = lowIndex; i <= mid; i++)
            {
                for (int j = mid + 1; j <= highIndex; j++)
                {
                    if(input[j] < input[i])
                    {
                        var temp = input[j];
                        Shift(input, i, j);
                        input[i] = temp;
                        mid++;
                        break;
                    }

                }
            }
            
        }

        private static void Shift(int[] input, int startindex, int endIndex)
        {
            for (int i = endIndex; i > startindex; i--)
            {
                input[i] = input[i-1];
            }
        }
    }
}
