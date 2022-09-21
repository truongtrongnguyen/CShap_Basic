using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    internal class FarmingAnimal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Food eatfood;//Khai báo kiểu dữ liệu là lớp Food để có thể new ra thức ăn được kế thừa từ nó
        public Food EatFood
        {
            get { return eatfood; }
            set { eatfood = value; }
        }

    }
}
