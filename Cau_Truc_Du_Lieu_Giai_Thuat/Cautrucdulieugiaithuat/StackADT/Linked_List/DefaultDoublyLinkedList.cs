using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackADT
{
    class DefaultDoublyLinkedList<T> : DoublyLinkedList<T>
    {
        public DefaultDoublyLinkedList()
        {
        }
        private int size;   //Số lượng Node đang tồn tại trong List của ta
        private Node<T> head = null;
        private Node<T> tail = null;

        public void clear()
        {
            Node<T> current = head;
            while (current != null)
            {
                Node<T> nextNode = current.Next;
                current.Next = null;
                current.Prey = null;
                current.data = default(T);

                current = nextNode;   //Gán thằng tiếp theo cho current để tiếp tục xóa
            }
            head = tail = null; //Cần cho thằng quản lí đầu danh sách và cuối danh sách về null như thế mới xóa sạch hoàn toàn
            size = 0;
        }
        public int Size()
        {
            return size;
        }
        public bool isEmpty()
        {
            return Size() == 0;
        }
        public void addLast(T element)
        {
            if (isEmpty()) head = tail = new Node<T>(element, null, null);  // Do là Node đầu tiên nên địa cỉ đầu và cuối Node điều là null
            else
            {
                Node<T> newNode = new Node<T>(element, tail, null); //Tạo ra một Node để thêm
                tail.Next = newNode;    //cho thằng quản lí cuối danh sách trỏ đến thằng vừa mới tạo
                tail = tail.Next;   //đồng thời gán thằng vừa mới tạo cho nó biệt danh là cuối danh sách
            }
            size++;
        }
        public void addFirt(T element)
        {
            if (isEmpty()) head = tail = new Node<T>(element, null, null);
            else
            {
                Node<T> newNode = new Node<T>(element, null, head);
                head.Prey = newNode;    //Cho thằng đầu danh sách trỏ ngược lên thằng cần thêm
                head = head.Prey;   //Gán cho thằng vừa thêm đó cho nó thành thằng đầu danh sách
            }
            size++;
        }
        public void add(T element)
        {
            addLast(element);
        }
        public T peekFirst()
        {
            if (isEmpty()) throw new Exception("Empty linked list!");
            return head.data;
        }
        public T peekLast()
        {
            if (isEmpty()) throw new Exception("Empty linked list!");
            return tail.data;
        }
        public T removeFirst()
        {
            if (isEmpty()) throw new Exception("Empty linked list!");
            T data = head.data;
            head = head.Next;   //Tiến hành xóa thằng đầu tiên
            size--; //đồng thời giảm số lượng phần tử lại
            if (isEmpty()) tail = null; //Nếu trường hợp sau khi xóa xong mà ds rỗng thì set cho tail về null luôn
            else head.Prey = null;
            return data;
        }
        public T removeLast()
        {
            if (isEmpty()) throw new Exception("Empty linked list!");
            T data = tail.data;
            tail = tail.Prey;
            size--;
            if (isEmpty()) head = null;
            else tail.Next = null;
            return data;
        }
        public T remove(Node<T> node)
        {
            if (node.Prey == null) removeFirst();
            if (node.Next == null) removeLast();

            node.Prey.Next = node.Next; //Tính chất bắt cầu, thằng node là thằng ở giữa và cho bắt cầu để liên kết với hai thằng cạnh bên
            node.Next.Prey = node.Prey;

            T data = node.data;
            size--;
            //Clear memory
            node.data = default(T);
            node.Next = null;
            node.Prey = null;
            node = null;
            return data;
        }
        public bool remove(object obj)   //Do nếu xóa mà danh sách còn rỗng thì sẽ lỗi nên ta chọn kiểu bool
        {
            Node<T> ob = new Node<T>((T)obj, null, null);
            Node<T> current = head; //Lấy thằng đầu danh sách để duyệt
            if (ob == null)
            {
                while (current != null)
                {
                    if (current.data == null)
                    {
                        remove(current);
                        return true;
                    }
                    current = current.Next;
                }
            }
            else
            {
                while (current != null)
                {
                    if (current.data.Equals(ob.data))
                    {
                        remove(current);
                        return true;
                    }
                    current = current.Next;
                }
            }
            return false;
        }
        public T removeAt(int index)
        {
            if (index < 0 || index > size) throw new ArgumentOutOfRangeException("index");
            Node<T> current;
            int i = 0;
            if (index < size / 2)
            {
                current = head;
                while (i != index)
                {
                    current = current.Next; 
                    i++;
                }
            }
            else
            {
                current = tail;
                i = size-1;
                while (i != index)
                {
                    current = current.Prey;
                    i--;
                }
            }
            return remove(current);
        }
        public int indexOf(object obj)
        {
            if (isEmpty()) throw new Exception("Empty linked list");
            Node<T> ob = new Node<T>((T)obj, null, null);

            //if (ob.data.Equals(head.data)) return 0;
            //if (ob.data.Equals(tail.data)) return size;

            //Node<T> current = head.Next;
            //int i = 1;
            //while(current!=null)
            //{
            //    if (current.data.Equals(ob.data)) return i;
            //    current = current.Next;
            //    i++;
            //}


            int index = 0;
            Node<T> current = head;
            if (ob.data == null)
            {
                while (current != null)
                {
                    if (current.data == null) return index;

                    current = current.Next;
                    index++;
                }
            }
            else
            {
                while (current != null)
                {
                    if (current.data.Equals(ob.data))
                    {
                        return index;
                    }
                    current = current.Next;
                    index++;
                }
            }
            return -1;
        }
        public bool contain(object obj)
        {
            return indexOf(obj) != -1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(size);
            sb.Append("[");
            Node<T> current = head;
            while (current != null)
            {
                sb.Append(current.data);
                if (current.Next != null) sb.Append(", ");
                current = current.Next;
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
