using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal static class QuickSort
    {

        /*
         * 1. Find the Pivot
         * 2. Find smaller elements and put it in left array, find larger elements and put it in the right array
         * 3. Call recursively
         */
        internal static void Sort(int[] input, int indexLow, int indexHigh)
        {
            if (input == null || input.Length <= 1)
            {
                return;
            }

            if (input.Length == 2)
            {
                if (input[0] > input[1])
                {
                    var temp = input[0];
                    input[0] = input[1];
                    input[1] = temp;
                }
                return;
            }
            if (indexLow < indexHigh)
            {
                int pivot = Partition(input, indexLow, indexHigh);
                Sort(input, indexLow, pivot - 1);
                Sort(input, pivot + 1, indexHigh);
            }
        }

        private static int Partition(int[] input, int indexLow, int indexHigh)
        {
            var pivot = indexHigh;
            var i = indexLow;
            int temp;

            for (int j = indexLow; j <= indexHigh; j++)
            {
                if (input[j] < input[pivot])
                {
                    temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                }
            }
            temp = input[pivot];
            input[pivot] = input[i];
            input[i] = temp;
            return i;
        }

    }
}
