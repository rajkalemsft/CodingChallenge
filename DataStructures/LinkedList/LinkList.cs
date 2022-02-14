using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{

    public class LinkList<T>
    {
        protected Node<T> head;

        public Node<T> Head
        {
            get
            {
                return head;
            }
        }

        public int Length
        {
            get
            {
                return ListLength();
            }
        }

        private int ListLength()
        {
            int count = 0;
            if(head == null)
            {
                return count;
            }

            var node = head;
            do
            {
                count++;
                node = node.Next;
            }while(node != null);

            return count;

        }

        //Add to rear
        public void Add(T valueToAdd)
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

        public void InsertAt(T valutToAdd, int position)
        {
            if(position <=0  ||  position > this.Length + 1 || (head == null && position > 1))
            {
                throw new ArgumentOutOfRangeException("position");
            }

            if (position == 1)
            {
                var newNode = new Node<T>()
                {
                    Data = valutToAdd,
                    Next = head,
                };
                head = newNode;
                return;
            }

            //Find the position -1 node
            // Build new node
            //Take node.Next into newNode.Next
            // node.next = newnode
            // 1,2,3,4

            Node<T> prevNode = head;
            int count = 2;

            while(count < position )
            {
                prevNode = prevNode.Next;
                count++;
            }
            var newNode2 = new Node<T>()
            {
                Data = valutToAdd,
                Next = prevNode.Next,
            };

            prevNode.Next = newNode2;
        }


    }
}
