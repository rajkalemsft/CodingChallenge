using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures.LinkedList
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }
    }
}
