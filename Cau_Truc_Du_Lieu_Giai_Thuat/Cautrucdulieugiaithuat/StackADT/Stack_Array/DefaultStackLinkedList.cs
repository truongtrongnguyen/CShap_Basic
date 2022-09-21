using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT
{
    internal class DefaultStackLinkedList<T>:stackADT<T>
    {
        private DoublyLinkedList<T> list= new DefaultDoublyLinkedList<T>();
        public DefaultStackLinkedList()
        {
     
        }
        public DefaultStackLinkedList(T element)
        {
            Push(element);
        }
        public void Push(T element)
        {
            list.addLast(element);
        }
        
        public T Pop()
        {
            return list.removeFirst();
        }
        public T Top()
        {
            return list.peekFirst();
        }
        public int Size()
        {
            return list.Size();
        }
        public void Clear()
        {
            list.clear();
        }
        public bool isEmpty()
        {
            return list.isEmpty();
        }
        public override string ToString()
        {
            return list.ToString();
        }
    }
}
