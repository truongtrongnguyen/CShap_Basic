using System;
using System.Collections.Generic;
using System.Text;

namespace Type_Attribute_Annotation
{
    internal class Su_Dung_Obsolete
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Obsolete("Phuong thuc nay da loi thoi, can thay boi ShowInfo")]
        public void Prints()
        {
            Console.WriteLine(Name);
        }
    }
}
