using System;
using System.Collections.Generic;
using System.Text;

namespace StackADT.Queue
{
    public class CircularArrayBaseQueue<T>:QueueADT<T>
    {
        private T[] arr;
        private int front;  //vị trí element đầu tiên
        private int end;    //vị trí phía sau element cuối cùng
        private int _size;
  
        public CircularArrayBaseQueue(int maxSize)
        {
            front = end = 0;
            _size = maxSize+1;
            arr = new T[_size];
        }
        public void enqueue(T element)
        {
            //if (isEmpty()) throw new ArgumentNullException("Empty Exception");
            
            arr[end] = element;
            if (++end == _size) end = 0; //Do mình khi thêm vào thì nó sẽ dịch thằng end lên tiếp theo và so sánh nếu nó bằng size thì cho nó vòng tròn lại vị trí 0
            if (end == front) throw new Exception("Queue is full");//Sau khi cho nó vòng lại thì check xem nó có đụng thằng front chưa nếu chưa thì list còn trống
        }
        public T dequeue()
        {
            if(isEmpty()) throw new ArgumentNullException("Empty Exception");
            T element = arr[front];
            arr[front] = default(T);//Clear phàn tử sau khi đã dequeue
            if (++front == _size) front = 0;//Do nó chỉ cần lấy phần tử phía trước nó ra thôi nên nó không cần quan tâm tới thằng end
            return element;
        }
        public T peek()
        {
            if (isEmpty()) throw new ArgumentNullException("Empty Exception");
            return arr[front];
        }
        public int size()
        {
            if (front > end) return (end + _size - front);
            return end - front;
        }
        public bool isEmpty()
        {
            return front == end;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(_size);
            sb.Append("[");
            for(int i=0;i<_size-1;i++)
            {
                sb.Append(arr[i]);
                if (i != _size - 1) sb.Append(", ");
            }
            sb.Append(arr[_size-1]);
            sb.Append("]");
            return sb.ToString();
        }
    }
}
