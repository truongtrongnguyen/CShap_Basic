using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NV
{
    internal class Staff:Add_information
    {
        private string name;
        private int age;
        private string address;
        private string job;
        private float salary;
        private float work_time;
        public Staff()
        { }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public float Work_Time
        {
            get { return work_time; }
            set { work_time = value; }
        }
        public void Add_nv_Staff()
        {
            Name = Add_Name();
           Age = Add_Age();
            Address = Add_Address();

        }
    }
}
