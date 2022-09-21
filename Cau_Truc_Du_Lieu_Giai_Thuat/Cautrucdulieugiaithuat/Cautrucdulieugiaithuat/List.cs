using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautrucdulieugiaithuat
{
    internal class List   
    {
        public List()
        {
            pHead = null;
            pTail = null;
        }

        public Node pHead;//Node quản lý đầu danh sách
        public Node pTail;//Node quản lý cuối danh sách
    }
}
