using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Sum
{
    internal class PlusMinus
    {
        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            if (arr.Count() == 0)
            {
                return;
            }

            int positiveNumbers = 0;
            int negativeNumbers = 0;
            int zeroNumbers = 0;
            foreach (var number in arr)
            {
                if (number > 0)
                {
                    positiveNumbers++;
                }
                else if (number < 0)
                {
                    negativeNumbers++;
                }
                else
                {
                    zeroNumbers++;
                }
            }
            Console.WriteLine($"Positive: {Math.Round((double)positiveNumbers / (double)arr.Count(), 6)}");
            Console.WriteLine($"Negative: {Math.Round((double)negativeNumbers / arr.Count(), 6)}");
            Console.WriteLine($"Zero: {Math.Round((double)zeroNumbers / arr.Count(), 6)}");
        }
    }
}
