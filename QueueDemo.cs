using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class QueueDemo
    {
        node front;
        node rear;

        public void enqueueData(int data)
        {
            node obj = new node(data);
            if (front == null)
            {
                rear = obj;
                front = rear;
            }
            else
            {
                rear.Next = obj;
                rear = rear.Next;

            }
        }
               public void Display()
            {

                if (front == null)
                {
                    Console.WriteLine("queue is empty");
                }
                else
                {
                    node temp = front;
                    while (temp!= null)
                    {
                        Console.WriteLine(temp.data + "");
                        temp = temp.Next;
                    }
                }

            }


        }
    }

