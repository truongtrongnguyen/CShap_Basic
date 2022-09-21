using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautrucdulieugiaithuat
{
    internal class Node
    {
        public Node()
        { }
        public Node(int x)
        {
            data = x;
            pNext = null;
        }
        private int data;//Dữ liệu chứa trong 1 cái node, có thể là sinh viên hoặc sách....
        private Node pNext;//Con trỏ dùng để liên kết các node với nhau

        public int Data { get => data; set => data = value; }
        internal Node PNext { get => pNext; set => pNext = value; }
    }
}
