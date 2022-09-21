using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT.Queue
{
    internal interface QueueADT<T>
    {
        void enqueue(T element);
        T dequeue();
        T peek();
        int size();
        bool isEmpty();
    }
}
