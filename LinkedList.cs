using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures
{
    internal class LinkedList
    {
        public node Head;


        public void AddNode(int data)
        {
            node n = new node(data);
            if (this.Head == null)
            {
                Head = n;
            }
            else
            {
                node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = n;
            }
            Console.WriteLine("{0} inserted into linklist", data);
        }
        public void display()
        {
            if (Head == null)
            {
                Console.WriteLine("linklist is empty");
            }
            else
            {
                node tempnode = Head;
                while (tempnode != null)
                {
                    Console.WriteLine(tempnode.data + "");
                    tempnode = tempnode.Next;
                }
            }

        }
        public void InsertInMiddle(int data)
        {
            node newNode = new node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                node slowPtr = Head;
                node fastPtr = Head;
                node prevNode = null;

                while (fastPtr != null && fastPtr.Next != null)
                {
                    fastPtr = fastPtr.Next.Next;
                    prevNode = slowPtr;
                    slowPtr = slowPtr.Next;
                }

                prevNode.Next = newNode;
                newNode.Next = slowPtr;
            }
        }

        public void PrintList()
        {
            node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void DeleteFirstElement()
        {
            if (Head == null)
            {
                return;
            }

            node temp = Head;
            Head = Head.Next;
            temp = null;
        }
        static void InsertionSort(LinkedList<int> list)
        {
            LinkedListNode<int> current = list.First?.Next;

            while (current != null)
            {
                LinkedListNode<int> temp = current.Previous;

                while (temp != null && temp.Value > current.Value)
                {
                    temp = temp.Previous;
                }

                if (temp == null)
                {
                    list.Remove(current);
                    list.AddFirst(current);
                }
                else
                {
                    list.Remove(current);
                    list.AddAfter(temp, current);
                }

                current = current.Next;
            }

        }
    }
}





