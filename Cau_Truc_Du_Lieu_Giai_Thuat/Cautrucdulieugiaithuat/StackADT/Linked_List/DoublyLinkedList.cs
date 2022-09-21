using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackADT
{
    interface DoublyLinkedList<T>
    {
        void clear();
        int Size();
        bool isEmpty();
        void addLast(T element);
        void addFirt(T element);
        void add(T element);
        T peekFirst();
        T peekLast();
        T removeFirst();
        T removeLast();
        T remove(Node<T> node);
        bool remove(object obj);
        T removeAt(int index);
        int indexOf(object obj);
        bool contain(object obj);
    }
}
