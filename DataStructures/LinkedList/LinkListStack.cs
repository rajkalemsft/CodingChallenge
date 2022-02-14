using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class LinkListStack <T> : LinkList<T>
    {

        //Stack - Insert and Delete happens at the same end. LIFO - Add to start
        public void Push(T valueToAdd)
        {
            var newNode = new Node<T>
            {
                Data = valueToAdd
            };

            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.Next = head;
            head = newNode;
        }

        //Stack - Insert and Delete happens at the same end. LIFO - Remove from start
        public T Pop()
        {
            if (head == null)
            {
                throw new ArgumentException("Empty Stack.");
            }

            var valueToDequeue = head.Data;
            head = head.Next;

            return valueToDequeue;
        }
    }
}
