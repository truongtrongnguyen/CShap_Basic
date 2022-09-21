using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StackADT.Binary_Search_Tree
{
    internal class BinarySearchTree<T>:TreeADT<T>, IComparable<T>
    {
        private int nodeCount;
        private Node<int> root = null;
        public bool isEmpty()
        {
            return false;
        }
        public int size()
        {
            return nodeCount;
        }
        public int height()
        {
            return height(root);
        }
        public bool contain(int element)
        {
            return contain(root, element);
        }
        public bool add(T element)
        {
            return false;
        }
        public bool remove(T element)
        {
            return false;
        }

        public int CompareTo([AllowNull] T other)
        {
            throw new NotImplementedException();
        }
        private int height(Node<int> node)//Hàm tính chiều cao của cây
        {
            if (node == null) return 0;
            return 1 + Math.Max(height(node.left), height(node.right));
            //lấy thằng dưới cùng là 1 cộng với thằng Max ở trên nó
        }
        private bool contain(Node<int> node, int element)
        {
            if (node == null) return false;
            else if(node.data==element)
            {
                return true;
            }
            else if(node.data>element)
            {
                return contain(node.left, element);
            }
            else if(node.data<element)
            { return contain(node.right, element); }
            return false;
        }
        private Node<int> add(Node<int> node, int element)
        {
            if(node==null)
            {
                node = new Node<int>(element, node.left, node.right);
            }
            else
            {
                if(node.data>element)
                {
                    node.right = add(node.right, element);
                }
            }
            return node;
        }
    }
}
