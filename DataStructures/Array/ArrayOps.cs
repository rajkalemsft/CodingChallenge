using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal static class ArrayOps
    {
        //Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.
        internal static void RotateArray(int[] inputArr, int numberOfElementsToRotate)
        {
            if (inputArr == null || inputArr.Length == 0 || numberOfElementsToRotate <= 0)
            {
                return;
            }

            /* Copy the array elements to be rotated to a temp array of length =  "number of elements to be moved"
             * Loop through the Original Array 
             *  - Start at the 0th index until the end of the array
             *  - Move the (current index + "number of elements to be moved") index to current index
             *  Loop through the temp array
             *  - Copy the current element into the index at "OriginalArray.Length - "number of elements to be moved" + Current Index
             *  - {0,1,2,3,4,5,6,7,8,9} Move 4 Elements
             */
            var elementsToRotate = new int[numberOfElementsToRotate];

            for (int i = 0; i < numberOfElementsToRotate; i++)
            {
                elementsToRotate[i] = inputArr[i];
            }

            for (int i = 0 ; i < inputArr.Length - numberOfElementsToRotate; i++)
            {
                inputArr[i] = inputArr[i + numberOfElementsToRotate];
            }

            int offset = inputArr.Length - numberOfElementsToRotate;
            for (int i = 0; i < numberOfElementsToRotate; i++)
            {
                inputArr[offset + i] = elementsToRotate[i];
            }
                /*
                    //{1,2,3,4,5,6,7}
                    for (var i = 0; i < numberOfElementsToRotate; i++)
                {
                    var temp = inputArr[0];

                    for (int j = 0; j < inputArr.Length; j++)
                    {
                        if (j != inputArr.Length - 1)
                        {
                            inputArr[j] = inputArr[j + 1];
                        }
                        else
                        {
                            inputArr[j] = temp;
                        }
                    }

                }*/
            }


        internal static void RearrangeArray(int[] inputArr)
        {
            //Given an array of elements of length N, ranging from 0 to N – 1.
            // All elements may not be present in the array.
            // If the element is not present then there will be -1 present in the array.
            // Rearrange the array such that A[i] = i and if i is not present, display -1 at that place.
            // Example: {-1, -1, 6, 1, 9, 3, 2, -1, 4, -1} --> [-1, 1, 2, 3, 4, -1, 6, -1, -1, 9]

            // Always 0 To N-1, No higher value, May have repeated number, may not have all the numbers
            // Loop through each element
            // -- If arr[i] <= N-1, temp = arr[arr[i]], arr[arr[i]] = arr[i], arr[i] = temp;
            // -- Check arr[i] /i == 1 || arr[i] /i == -1 keep the element

            for (int i = 0; i < inputArr.Length; i++)
            {
                var shuffle = false;
                do
                {
                    shuffle = Shuffle(inputArr, i);
                } while (shuffle);

            }
        }

        private static bool Shuffle(int[] inArr, int index)
        {

            if (inArr[index] == -1 || inArr[index] / index == 1)
            {
                return false;
            }

            if (inArr[index] <= inArr.Length - 1)
            {
                var temp = inArr[index];
                inArr[index] = inArr[temp];
                inArr[temp] = temp;
                return true;
            }
            return false;
        }

        internal static void ReverseArray(int[] inputArr)
        {
            if (inputArr == null || inputArr.Length == 0 || inputArr.Length == 1)
            {
                return;
            }

            var median = inputArr.Length / 2;
            var upperBoundIndex = inputArr.Length -1 ;

            for (int i = 0; i < median; i++)
            {
                var temp = inputArr[i];
                inputArr[i] = inputArr[upperBoundIndex - i];
                inputArr[upperBoundIndex - i] = temp;
            }
        }

    }
}
