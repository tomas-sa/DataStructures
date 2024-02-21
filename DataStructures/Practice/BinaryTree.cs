using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Practice
{
    internal class BinaryTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }
        private TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);
            if (node == null)
            {
                return newNode;
            }
            if (key < node.Key)
            {
                node.LeftNode = InsertItem(node.LeftNode, key, value);
            }else if (key > node.Key)
            {
                node.RightNode = InsertItem(node.RightNode, key, value);
            }
            return node;
        }

        public String Find(int key)
        {
            TreeNode newNode = Find(Root, key);
            return newNode == null ? null : newNode.Value;
        }

        private TreeNode? Find(TreeNode node, int key)
        {
            if (node == null || node.Key == key)
            {
                return node;
            }
            if (key < node.Key)
            {
                return Find(node.LeftNode, key);
            }

            return Find(node.RightNode, key);
        }
    }
}
