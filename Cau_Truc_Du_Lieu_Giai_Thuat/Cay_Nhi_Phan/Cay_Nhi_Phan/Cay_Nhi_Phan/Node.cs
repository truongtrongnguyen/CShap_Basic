using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cay_Nhi_Phan
{
    internal class Node
    {
        public Node()
        {
        }
        public int data;//Dữ liệu cua node
        public Node pLeft;//node liên kết bên trái của cây <-> cây con trái
        public Node pRight;//node liên kết bên phải của cây <-> cây con phải
    }
}
