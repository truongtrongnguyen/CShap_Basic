using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackADT
{
    public class Doubly_Linked_List_Ong_Dev
    {
    }
    class Node<T>   //Node quản lý 2 chiều
    {
        public T data;
        public Node<T> Prey { get; set; }   //chứa địa chỉ đầu của Node
        public Node<T> Next { get; set; }   //chứa địa chỉ cuối của Node
        public Node(T data, Node<T> prey, Node<T> next)
        {
            this.data = data;
            this.Prey = prey;
            this.Next = next;
        }
        public override string ToString()
        {
            return data.ToString();
        }
    }
}
