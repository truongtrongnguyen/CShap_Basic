using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc_Ghi_File_SV
{
    public class List
    {
        public List()
        {
            pHead = null;
            pTail = null;
        }
        public Node pHead { get; set; }
        public Node pTail { get; set; }
    }
}
