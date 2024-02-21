using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class LinkedList
    {
        public Node? Head {  get; set; }

        public void Add(string value)
        {
            Node temp = new Node(value);
            temp.Next = Head;
            Head = temp;
        }
    }
}
