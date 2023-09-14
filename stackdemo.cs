using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class stackdemo
    {

        node top;
        public stackdemo()
        {
            top = null;
        }
        public void Pushnode(int data)
        {
            node n = new node(data);
            n.Next = top;
            top = n;
            Console.WriteLine(data);
        }
        public void Display()
        {

            if (top == null)
            {
                Console.WriteLine("linklist is empty");
            }
            else
            {
                node tempnode = top;
                while (tempnode != null)
                {
                    Console.WriteLine(tempnode.data + "");
                    tempnode = tempnode.Next;
                }
            }

        }
    }
}
    
   

