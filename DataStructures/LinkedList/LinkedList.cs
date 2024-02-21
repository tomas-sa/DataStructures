using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    internal class LinkedList
    {
        public Node? Head {  get; set; }

        public void InsertFirst(int numero)
        {
            Node temporal = new Node();
            temporal.Data = numero;
            temporal.Next = Head;
            Head = temporal;
        }

        public void InsertLast(int numero)
        {
            Node temporal = Head;
            while(temporal.Next != null)
            {
                temporal = temporal.Next;
            }
            Node nuevo = new Node();
            nuevo.Data = numero;
            temporal.Next = nuevo;
        }

        public void DeleteFirst()
        {
            Node temporal = Head;
            Head = temporal.Next;
        }

        public void DeleteLast()
        {
            Node temporal = Head;
            while (temporal.Next.Next != null)
            {
                temporal = temporal.Next;
            }
            temporal.Next = null;
        }

        public void IterateThrough()
        {
            Node temporal = Head;
            while (temporal != null)
            {
                temporal.DisplayNode();
                temporal = temporal.Next;
            }
        }
    }
}
