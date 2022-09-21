using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT
{
    public class DefaultStackADT<T>: stackADT<T>
    {
        public DefaultStackADT()
        { }
        public DefaultStackADT(int size)
        {
            arr = new DynamicArray<T>(size);
        }
        private DynamicArray<T> arr;
        private int index = -1;

        public void Push(T element)
        {
            index++;
            arr.add(element);
        }
        public T Pop()
        {   
            return arr.removeAtWithouMoving(index--);
        }
        public T Top()
        {
            return arr.get(Size() - 1);
        }
        public int Size()
        {
            return arr.size();
        }
        public bool isEmpty()
        {
            return arr.isEmpty();
        }
        public void Clear()
        {
            arr.clear();
        }
        public override string ToString()
        {
            return arr.ToString();
        }
    }
}
