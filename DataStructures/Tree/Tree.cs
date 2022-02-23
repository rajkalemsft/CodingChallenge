using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree
{
    internal class Tree<T>
    {
        private Node Root;

        public Tree()
        {

        }
        public Tree(int data)
        {
            Root = new Node { Data = data };
        }

        public void BuildTreeFromInOrderTraversalSequence()
        {
            /*
             *  InOrder Traversal Sequence [ 2,3,4,5,6,7,8 ]
             *  
             *  
             *  
             */ 
        }
    }
}
