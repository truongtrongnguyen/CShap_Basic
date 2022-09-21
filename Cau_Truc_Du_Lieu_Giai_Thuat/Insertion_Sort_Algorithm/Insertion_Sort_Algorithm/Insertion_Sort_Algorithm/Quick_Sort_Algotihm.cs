using System;
using System.Collections.Generic;
using System.Text;

namespace Insertion_Sort_Algorithm
{
    internal class Quick_Sort_Algotihm
    {
        public void doQuickSort(int[] items)
        {
            quickSort(items, 0, items.Length - 1);
        }
        public int [] quickSort(int[] items, int left, int right)
        {
            int index;
            if(items.Length>1)
            {
                index = partition(items, left, right);
                if (left < index - 1)
                {
                    quickSort(items, left, index-1);
                }
                if(index<right)
                {
                    quickSort(items, index, right);
                }
            }
            return items;
        }
        public int partition(int[] items, int left, int right)
        {
            var pivot = getPivot(items, left, right);
            int i = left;   //left pointer
            int j = right;  //right pointer
            while(i<=j)
            {
                while (items[i]<pivot)
                {
                    i++;
                }
                while (items[j]>pivot)
                {
                    j--;
                }
                if(i<=j)
                {
                    Swap(ref items[i],ref items[j]);
                    i++;
                    j--;
                }
            }
            return i;
        }
        public int getPivot(int[] items, int left, int right)
        {
            int mid = (left + right) / 2;
            if (items[mid] < items[left])
            {
                Swap(ref items[mid], ref items[left]);
            }
            if (items[left] < items[right])
            {
                Swap(ref items[left], ref items[right]);
            }
            if (items[mid] < items[right])
            {
                Swap(ref items[mid], ref items[right]);
            }
            return items[right];
        }
        public void Swap(ref int a,ref  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
