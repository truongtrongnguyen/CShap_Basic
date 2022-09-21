using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT
{
    public interface stackADT<T>
    {
        void Push(T element);
        T Pop();
        T Top();
        int Size();
        void Clear();
        bool isEmpty();
    }
}
