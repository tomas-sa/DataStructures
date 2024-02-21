using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class Node
    {
        public int Key {  get; set; }
        public string Value { get; set; }
        public Node? Next { get; set; }

        public Node(string value)
        {
            this.Value = value;
            this.Key = Math.Abs((value[0] - 'a') / 2);
        }
    }
}
