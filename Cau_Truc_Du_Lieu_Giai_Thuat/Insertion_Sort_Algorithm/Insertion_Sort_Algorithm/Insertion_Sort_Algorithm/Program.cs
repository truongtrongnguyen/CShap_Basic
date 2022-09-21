using System;
using System.Timers;
namespace Insertion_Sort_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[] {7, 2, 4, 9, 6, 5, 10};

            //Insertion_Sort(ref a);
            //Console.WriteLine("vi tri: " + Search(a, 2));

            Quick_Sort_Algotihm test = new Quick_Sort_Algotihm();
            test.doQuickSort(a);
            Dicplay(a);

            Console.ReadKey();
        }
        public static void Dicplay(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public static void Insertion_Sort(ref int[] array)
        {
            //Nó được sử dụng hiệu quả nhất khi list nó gần như được sắp xếp, ví dụ như thêm một element vào danh sách đã được sắp xếp từ trước
            var length = array.Length;
            for (int i = 1; i < length; i++)
            {
                int key = array[i];     //cho biến key giữ giá trị như biến tạm
                int j = i - 1;
                while (j >= 0)
                {
                    if (array[j] > key)
                    {
                        array[j + 1] = array[j];    //còn biến key giữ lại giá trị ban đầu
                        j--;     //giảm giá trị của j về một đơn vị
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = key;     //dòng này giúp giữ giá trị khi nó có swap hoặc không swap
            }
        }
        public static int Search(int[] a, int value)
        {

            int low = 0;
            int hight = a.Length;
            while (low <= hight)
            {
                var mid = (hight + low) / 2;
                if (a[mid] == value)
                {
                    return mid;
                }
                else if (a[mid] < value)
                {
                    low = mid + 1;
                }
                else if (a[mid] > value)
                {
                    low = mid-1;
                }
            }
            return -1;
        }
    }


}
