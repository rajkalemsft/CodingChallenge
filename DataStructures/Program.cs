namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileProcessor();
            file.CreateFile();
            file.SplitFile();

            //string[] planets1 = { "Mercury", "Venus", "Earth", "Jupiter" };
            //string[] planets2 = { "Mercury", "Earth", "Mars", "Jupiter" };

            //IEnumerable<string> query = planets1.Intersect(planets2).ToList();

            //foreach (var str in query)
            //{
            //    Console.WriteLine(str);
            //}

            //#region RorateArray by 'N' elements

            //var arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //ArrayOps.RotateArray(arr, 4);

            //#endregion

            //#region Rearrange array to have elements with matching index, in case element is not found in array have it as -1
            //var arrToarrange = new int[10] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };

            //ArrayOps.RearrangeArray(arrToarrange);
            //#endregion

            //#region Reverse Array
            //var arrToReverse = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //ArrayOps.ReverseArray(arrToReverse);

            ////var arr2 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            ////ArrayOps.ReverseArray(arr2);
            //#endregion

            //#region Generic Queue
            //var queue = new LinkListQueue<double>();
            //queue.Queue(1.1);
            //queue.Queue(2.1);
            //queue.Queue(3.1);
            //queue.Queue(4.1);

            //queue.DeQueue();
            //#endregion

            //#region Generic Stack
            //var stack = new LinkListStack<double>();

            //stack.Push(1.1);
            //stack.Push(2.1);
            //stack.Push(3.1);
            //stack.Push(4.1);
            //stack.Pop();
            //#endregion

            //#region LinkedList
            //SinglyLinkedList llist = new SinglyLinkedList();

            //llist.InsertNode(1);
            //llist.InsertNode(2);
            //llist.InsertNode(3);
            //llist.InsertNode(4);
            //llist.InsertNode(5);

            //llist.Reverse();
            //var list = new LinkList<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.InsertAt(10, 1);

            //var circularList = new CircularLinkList<int>();

            //circularList.Add(1);
            //circularList.Add(2);
            //circularList.Add(3);
            //circularList.Add(4);
            //circularList.IsCircular(list.Head);

            //circularList.ToCirular();

            //circularList.IsCircular(list.Head);

            //var listTocheck = new LinkList<int>();

            //listTocheck.Add(5);
            //listTocheck.Add(6);
            //listTocheck.Add(7);
            //listTocheck.Add(1);

            //var issorted = listTocheck.IsSortedList;
            //#endregion

            //#region String Reversal
            //var outStr = StringOps.ReverseString("RajendraKalew");

            //#endregion

            //#region Binry Search
            //var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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

            //var inputStrArr = new string[] { "abc", "def", "hij", "klm", "nop" };
            //var returnValue11 = BinarySearch<string>.Search(inputStrArr, "abc");
            //var returnValue21 = BinarySearch<string>.Search(inputStrArr, "def");
            //var returnValue31 = BinarySearch<string>.Search(inputStrArr, "hij");
            //var returnValue41 = BinarySearch<string>.Search(inputStrArr, "klm");
            //var returnValue51 = BinarySearch<string>.Search(inputStrArr, "nop");
            //var returnValue61 = BinarySearch<string>.Search(inputStrArr, "qrs");
            //#endregion

            //#region Recursion
            //var sumList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var sum = Recursion.SumListItems(sumList);

            //var countList = new int[] { 1 };

            //var count = Recursion.CountNumberOfItemsInList(countList);

            //var maxList = new int[] { -1, -2, -3, -4 };

            //var maxNum = Recursion.MaximumNumberInList(maxList);

            //#endregion

            //#region Sorting
            //var inputArr = new int[] { 5, 4, 1, 3, 18, 21, -1 };

            //QuickSort.Sort(inputArr, 0, inputArr.Length - 1);

            //var inputArr2 = new int[] { 56, 93, 63, 42, 54, 9, 1, 4, 6, 2 };

            //MergeSort.Sort(inputArr2);

            //#endregion

            //#region Tree Traversal

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
            //tree.PreOrderTraversal(tree.Root);
            //tree.PostOrderTraversal(tree.Root);

            //#endregion

            //#region Tree Key Value Store
            //try
            //{
            //    var treekv = new TreeKv();
            //    treekv.Create("/first_level", "value1");
            //    treekv.Create("/sibling", "value2");
            //    treekv.Create("/first", "value1");
            //    treekv.Create("/first/second", "value2");
            //    treekv.Create("/first/third", "value3");
            //    var value = treekv.Get("/first/third");
            //    var value1 = treekv.Set("/first/third", "valueReplaced");
            //    treekv.Delete("/first/second");
            //    treekv.Delete("/fourth");

            //}
            //catch (System.Exception ex)
            //{

            //}

            //#endregion

            //var temp = Math.Round((decimal)3 / 6, 6);
            ////Result.plusMinus(new List<int> { -4, 3, -9, 0, 4, 1});


        }

    }

}
