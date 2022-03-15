using DataStructures.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
	{
		static void Main(string[] args)
		{
            //var arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //ArrayOps.RotateArray(arr, 4);

            //var arr = new int[10] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };

            //ArrayOps.RearrangeArray(arr);

            //var arr = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //ArrayOps.ReverseArray(arr);

            //var arr2 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //ArrayOps.ReverseArray(arr2);


            //var queue = new LinkListQueue<double>();
            //queue.Queue(1.1);
            //queue.Queue(2.1);
            //queue.Queue(3.1);
            //queue.Queue(4.1);

            //queue.DeQueue();

            //var stack = new LinkListStack<double>();

            //stack.Push(1.1);
            //stack.Push(2.1);
            //stack.Push(3.1);
            //stack.Push(4.1);
            //stack.Pop();


            //var list = new LinkList<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.InsertAt(10, 1);

            //var list = new CircularLinkList<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.IsCircular(list.Head);

            //list.ToCirular();

            //list.IsCircular(list.Head);

            //var list = new LinkList<int>();

            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(1);
            //var issorted = list.IsSortedList;

            //var outStr = StringOps.ReverseString("RajendraKalew");

            //var input = new int[] { 1,2,3,4,5,6,7,8,9 };
            //var returnValue1 = BinarySearch<int>.Search(input, 1);
            //var returnValue2 = BinarySearch<int>.Search(input, 2);
            //var returnValue3 = BinarySearch<int>.Search(input, 3);
            //var returnValue4 = BinarySearch<int>.Search(input, 4);
            //var returnValue5 = BinarySearch<int>.Search(input, 5);
            //var returnValue6 = BinarySearch<int>.Search(input, 6);
            //var returnValue7 = BinarySearch<int>.Search(input, 7);
            //var returnValue8 = BinarySearch<int>.Search(input, 8);
            //var returnValue9 = BinarySearch<int>.Search(input, 9);
            //var returnValue10 = BinarySearch<int>.Search(input, 10);

            ////var input = new string[] { "abc", "def", "hij", "klm", "nop"};
            //var returnValue1 = BinarySearch<string>.Search(input, "abc");
            //var returnValue2 = BinarySearch<string>.Search(input, "def");
            //var returnValue3 = BinarySearch<string>.Search(input, "hij");
            //var returnValue4 = BinarySearch<string>.Search(input, "klm");
            //var returnValue5 = BinarySearch<string>.Search(input, "nop");
            //var returnValue6 = BinarySearch<string>.Search(input, "qrs");


            //var input = new int[] { 1,2,3,4,5,6,7,8,9,10 };

            //var sum = Recursion.SumListItems(input);

            //var input = new int[] { 1 };

            //var sum = Recursion.CountNumberOfItemsInList(input);

            //var input = new int[] { -1,-2,-3,-4 };

            //var maxNum = Recursion.MaximumNumberInList(input);

            //var input = new int[] { 5,4,1,3,18,21,-1 };

            //QuickSort.Sort(input, 0 ,input.Length -1);

            //var input = new int[] { 56, 93, 63, 42, 54, 9, 1, 4, 6,2 };

            //MergeSort.Sort(input);


            //var tree = new Tree(10);
            //tree.Add(8);
            //tree.Add(9);
            //tree.Add(4);
            //tree.Add(5);
            //tree.Add(3);
            //tree.Add(17);
            //tree.Add(14);
            //tree.Add(11);
            //tree.Add(12);
            //tree.Add(19);
            //tree.Add(18);
            //tree.Add(20);

            //tree.InOrderTraversal(tree.Root);
            //try
            //{
            //    var tree = new TreeKv();
            //    tree.Create("/first_level", "value1");
            //    tree.Create("/sibling", "value2");
            //    tree.Create("/first", "value1");
            //    tree.Create("/first/second", "value2");
            //    tree.Create("/first/third", "value3");
            //    var value =tree.Get("/first/third");
            //    var value1 =tree.Set("/first/third", "valueReplaced");
            //    tree.Delete("/first/second");
            //    tree.Delete("/fourth");

            //}
            //catch (System.Exception ex)
            //{

            //}
            var temp = Math.Round((decimal)3/6, 6);
            //Result.plusMinus(new List<int> { -4, 3, -9, 0, 4, 1});

        }


    }

    class Result
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
        Console.WriteLine($"Positive: {Math.Round((double)positiveNumbers / (double)arr.Count(),6)}");
        Console.WriteLine($"Negative: {Math.Round((double)negativeNumbers / arr.Count(), 6)}");
        Console.WriteLine($"Zero: {Math.Round((double)zeroNumbers / arr.Count(), 6)}");
    }

}
}
