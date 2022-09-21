using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT.Queue
{
    internal class LinkedListBaseQueue<T>:QueueADT<T>
    {
        private DoublyLinkedList<T> list = new DefaultDoublyLinkedList<T>();
        public LinkedListBaseQueue(T element)
        {
            enqueue(element);
        }
        public LinkedListBaseQueue()
        { }
        public void enqueue(T element)
        {
            list.addLast(element);
        }
        public T dequeue()
        {
            if (list.isEmpty()) throw new ArgumentNullException();
            return list.removeFirst();
        }
        public T peek()
        {
            if (list.isEmpty()) throw new ArgumentNullException();
            return list.peekFirst();
        }
        public int size()
        {
            return list.Size();
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
