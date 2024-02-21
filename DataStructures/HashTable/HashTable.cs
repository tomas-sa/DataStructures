using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class HashTable
    {
        public int Size { get; set; }
        public Node[] Nodes { get; set; }

        public HashTable(int size) 
        {
            this.Nodes = new Node[size];
        }

        public int AddNode(string value)
        {
            Node nodo = new Node(value);
            if (Nodes[nodo.Key] != null)
            {
                Node temp = Nodes[nodo.Key];
                nodo.Next = temp;
                Nodes[nodo.Key] = nodo;
                return nodo.Key;
            }
            else
            {
                Nodes[nodo.Key] = nodo;
                return nodo.Key;
            }
        }

        public List<Node> Find(int key)
        {
            List<Node> lista = new List<Node>();
            Node nodo = Nodes[key];
            while (nodo != null)
            {
                lista.Add(nodo);
                nodo = nodo.Next;
            }

            return lista;
        }
    }
}
