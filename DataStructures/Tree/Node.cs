using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree
{
    internal class Node <T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
    }
}
