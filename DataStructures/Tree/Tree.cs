using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class Tree
    {
        internal Node Root;

        public Tree()
        {

        }
        public Tree(int data)
        {
            Root = new Node { Data = data };
        }

        public void Add(int value)
        {
            AddToTree(Root, value);
        }

        private void AddToTree(Node node, int value)
        {
            var newNode = new Node()
            {
                Data = value
            };

            if (node == null)
            {
                node = newNode;
                return;
            }
            if (node.Data < value)
            {
                if (node.Right != null)
                {
                    AddToTree(node.Right, value);
                }
                else
                {
                    node.Right = newNode;
                }
            }
            if (node.Data > value)
            {
                if (node.Left != null)
                {
                    AddToTree(node.Left, value);
                }
                else
                {
                    node.Left = newNode;
                }
            }
        }

        public void InOrderTraversal(Node node)
        {
            if(node == null)
            {
                return;
            }
            InOrderTraversal(node.Left);
            
            Console.WriteLine(node.Data);

            InOrderTraversal(node.Right);
        }

        public void PreOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Data);
        }

    }
}
