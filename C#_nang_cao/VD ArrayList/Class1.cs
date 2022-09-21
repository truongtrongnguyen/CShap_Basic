using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_ArrayList
{
    public class Person   
    {
        // Tạo ra 1 class Person có 2 thông số chính là name và ager
        private string name;
        private int age;
        public Person(string name, int ager)
        {
            this.name = name;
            this.age = ager;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Ager
        {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return "name: " + name + " |Ager: " + age;
        }

    }
}
