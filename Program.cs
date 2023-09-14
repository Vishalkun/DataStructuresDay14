using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueDemo queueDemo = new QueueDemo();
            queueDemo.enqueueData(56);
            queueDemo.enqueueData(30);
            queueDemo.enqueueData(70);
            queueDemo.Display();

            /*  LinkedList<int> list = new LinkedList<int>();
              list.AddFirst(56);
              list.AddFirst(30);
              list.AddFirst(70);

              list.Remove(56);
              list.RemoveLast();
             // list.AddLast(30);
              //list.AddLast(70);
              //list.AddLast(56);
              foreach (int i in list)
              {
                  Console.WriteLine(i);
              }*/
            /*LinkedList linked = new LinkedList();
            linked.AddNode(56);
            //linked.AddNode(30);
            linked.AddNode(70);
            linked.display();
            linked.InsertInMiddle(30);
            *//*linked.Head = new node(11);
            node second = new node(2);
            node third = new node(3);
            linked.Head.Next = second;
            second.Next = third;*//*
            linked.DeleteFirstElement();
           
            linked.PrintList();*/

            /* LinkedList<int> myLinkedList = new LinkedList<int>();


             myLinkedList.AddLast(1);
             myLinkedList.AddLast(3);
             myLinkedList.AddLast(5);
             myLinkedList.AddLast(2);
             myLinkedList.AddLast(4);


             InsertionSort(myLinkedList);


             foreach (int element in myLinkedList)
             {
                 Console.WriteLine(element);
             }
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
            */






            /*LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(56);
            //linkedList.AddLast(70);
            linkedList.AddLast(70);

            LinkedListNode<int> node = linkedList.Find(56); // Find the node with value 2
            if (node != null)
            {
                linkedList.AddAfter(node, 30); // Insert 3 after the node with value 2
            }

            // Print the linked list to verify the insertion
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }*/
        }
      }

    // This code will insert the value 3 after the node with the value 2, resulting in a linked list with values 1 -> 2 -> 3 -> 4.*/

    /*stackdemo obj = new stackdemo();
    obj.Push(1);
    obj.Push(2);
    obj.Push(3);
    obj.Push(4);
    obj.Push(5);
    foreach (var item in obj)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("============================");
    obj.Pop();

    foreach (var item in obj)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("============================");
    Console.WriteLine(obj.Peek());
*/
    /* stackdemo obj= new stackdemo();
     obj.Pushnode(70);

     obj.Pushnode(36);
     obj.Pushnode(50);
     Console.WriteLine("the elements that are pushed");
     obj.Display();*/

    /*  Queue queue = new Queue();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Enqueue(4);
      queue.Enqueue(5);

      foreach (var item in queue)
      {
          Console.WriteLine(item);
      }
      Console.WriteLine("============================");
      queue.Dequeue();

      foreach (var item in queue)
      {
          Console.WriteLine(item);
      }
      Console.WriteLine("============================");
      Console.WriteLine(queue.Count);

*/

 
        }
    

