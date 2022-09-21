using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT.Binary_Search_Tree
{
    public  interface TreeADT<T>:IComparable<T>
    {
        bool isEmpty();
        int size();
        int height();
        bool contain(int element);
        bool add(T element);
        bool remove(T element);
    }
}
