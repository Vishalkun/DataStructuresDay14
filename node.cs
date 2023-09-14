using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class node
    {
        public int data;
        public node Next;


        public node(int data) {
        this.data = data;
            Next = null;
        }
    }

}
