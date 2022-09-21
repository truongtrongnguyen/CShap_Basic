using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StackADT
{
    public interface Iterator<T>
    {
        Iterator<T> iterator();
        bool hasNext();
        T next();
    }

    public class DynamicArray<T>
    {

        private T[] arr;
        private int capacity=0;
        private int size_=0;


        public DynamicArray()
        {
            capacity = 10;
        }
        public DynamicArray(int capacity)
        {
            if (capacity < 0) throw new Exception("capacity not nagative" + capacity);
            this.capacity = capacity;
            arr = new T[capacity];
        }
        public int size()
        {
            return this.size_;
        }
        public bool isEmpty()
        {
            return size() == 0;
        }
        public T get(int index)
        {
            return arr[index];
        }
        public void set(int index, T element)
        {
            if (index < 0) throw new ArgumentOutOfRangeException("index");
            arr[index] = element; 
        }
        public void clear()
        {
            for (int i = 0; i < size_; i++)
            {
                arr[i] = default(T);
            }
            size_ = 0;
        }
        public void add(T element)
        {
            if (size_ >= capacity - 1)
            {
                if (capacity == 0) capacity = 1;    //Nếu danh sách arr chưa có phần tử nào hoặc vừa bị clear
                else capacity *= 2;     //Nếu danh sách arr đã tồn tại phần tử và sắp lưu trữ hết thì ta sẽ nâng capacity x2 lên
                T[] newarr = new T[capacity];
                for (int i = 0; i < size_; i++)
                {
                    newarr[i] = arr[i];
                }
                arr = newarr;   //Cần gán trả lại thuộc tính cho arr
            }

            arr[size_++] = element;     //Gán phần tử mới vào và tawg lên một đơn vị
           
        }
        public T removeAt(int removeindex)
        {
            if (removeindex < 0 || removeindex > size_) throw new ArgumentOutOfRangeException();
            T element = arr[removeindex];
            T[] newarr = new T[size_ - 1];
            for(int oldArrIndex=0, oldNewArrIndex=0; oldArrIndex<size();oldArrIndex++, oldNewArrIndex++)
            {
                if(oldArrIndex==removeindex)
                {
                    oldNewArrIndex--;
                }
                else
                {
                    newarr[oldNewArrIndex] = arr[oldArrIndex];
                }
            }
            arr = newarr;
            capacity = --size_; //Thu gọn không gian bộ nhớ lại để đỡ tốn dung lượnglưu trữ mở rộng
            return element;
        }
        public T removeAtWithouMoving(int removeIndex)
        {
            if (removeIndex < 0 || removeIndex > size_) throw new ArgumentOutOfRangeException();
            T item = arr[removeIndex];
            arr[removeIndex] = default(T);
            capacity=size_--;
            return item;
        }
        public void remove(object element)
        {
            int index = indexOf(element);
            removeAt(index);
        }
        public int indexOf(object element)
        {
            for(int i=0;i<size_;i++)
            {
                if(element == null)
                {
                    if (arr[i] == null) return i;
                }
                else
                {
                    if(element.Equals(arr[i])) return i;
                } 
            }
            return -1;
        }
        public bool contain(object element)
        {
            return indexOf(element) != -1;
        }
        public override string ToString()
        {
            if (isEmpty()) return "[ ]";//Nếu danh sách rỗng thì trả về
            else
            {
                StringBuilder sb = new StringBuilder(size_);
                sb.Append("[");
                for(int i=0;i<size_-1;i++)  //Chỉ lấy đến phần tử gần cuối vì cái phần tử cuối mình không lấy dấu phẩy
                {
                    sb.Append(arr[i]).Append(", ");     //Thêm phần tử rồi thêm dâu phẩy
                }   
                sb.Append(arr[size_-1]).Append("]");
                return sb.ToString();
            }
        }
    }
}
