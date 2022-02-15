using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class LinkListQueue<T>: LinkList<T> where T : IComparable<T>
    {
        //Queue - Insert and Delete happens at diff ends. Insert in rear and remove from front. FIFO - Add to rear
        public void Queue(T valueToAdd)
        {
            if (head == null)
            {
                head = new Node<T>
                {
                    Data = valueToAdd
                };
                return;
            }


            var node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new Node<T> { Data = valueToAdd };

        }

        //Queue - Insert and Delete happens at diff ends. Insert in rear and remove from front. FIFO - Remove from front
        public T DeQueue()
        {
            if (head == null)
            {
                throw new ArgumentException("Empty Queue.");
            }

            var valueToDequeue = head.Data;
            head = head.Next;

            return valueToDequeue;
        }

    }
}
