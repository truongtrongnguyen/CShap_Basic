using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    internal class Food
    {
        private string name;
        private float price;
        public string Name_Food
        {
            get { return name; }
            set { name = value; }
        }
      
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// caculate total amount of food weight
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        /// truyền vào lượng thức ăn mà con vật ăn/ngày rồi nhân với giá của thức ăn đó
        public float Amout(float weight)
        { return weight * Price; }
    }
}
