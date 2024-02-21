using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Practice
{
    internal class TreeNode
    {
        public int Key {  get; set; }
        public string Value { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }

        public TreeNode(int key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
