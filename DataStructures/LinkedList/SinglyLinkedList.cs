﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
        public void Reverse()
        {
            if (head == null)
            {
                return;
            }

            var nextNode = head.next;
            tail = head;
            do
            {
                var temp = nextNode.next;
                nextNode.next = head;
                head = nextNode;
                nextNode = temp;
            } while (nextNode != null);
            tail.next = null;
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.WriteLine(sep);
                }
            }
        }
    }
}
