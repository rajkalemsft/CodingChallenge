using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class CircularLinkList<T> : LinkList<T> where T : IComparable<T>
    {
        public void ToCirular()
        {
            if (head == null)
            {
                return;
            }


            var node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = head;
        }

        public bool IsCircular(Node<T> node)
        {
            if(node == null || node.Next == null)
            {
                return false;
            }
            var prevNode = node;
            var isCircular = true;

            do
            {
                node = node.Next;
                if (node == null)
                {
                    isCircular = false;
                    break;
                }
            } while (node != prevNode);

            return isCircular;
        }

        public int CirculerListLength()
        {
            int count = 0;

            if (head == null)
            {
                return count;
            }

            var node = head;
            count++;
            while (node.Next != null)
            {
                node = node.Next;
                count++;
            }

            return count;
        }


    }
}
