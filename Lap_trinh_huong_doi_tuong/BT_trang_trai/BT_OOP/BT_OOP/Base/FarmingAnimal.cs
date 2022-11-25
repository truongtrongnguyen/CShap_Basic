using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP.Base
{
    internal class FarmingAnimal
    {
        private string name;
        private Food eatfood;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Food EatFood //Khai báo kiểu dữ liệu là lớp Food để có thể new ra thức ăn được kế thừa từ nó
        {
            get { return eatfood; }
            set { eatfood = value; }
        }
    }
}
