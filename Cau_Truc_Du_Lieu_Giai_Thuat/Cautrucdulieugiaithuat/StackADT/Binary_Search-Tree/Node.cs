using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT.Binary_Search_Tree
{
    public  class Node<T>
    {
        public T data { get; set; }
        public Node<T> left { get; set; }
        public Node<T> right { get; set; }
        public Node() { }
        public Node(T data, Node<T> left, Node<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public override string ToString()
        {
            return data.ToString();
        }
    }
}
