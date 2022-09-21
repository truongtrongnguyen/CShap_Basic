using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    // Mỗi con vật sẽ có một List<FarmingAnimalcontroler> này
    internal class FarmingAnimalcontroler
    { 
        private List<FarmingAnimal> animallist; //creaat a list animal 
        /// <summary>
        /// List animal  of barn (danh sách động vật của chuồng)
        /// </summary>
        internal List<FarmingAnimal> AnimalList
        {
            get { return animallist; }
            set { animallist = value; }
        }
        public FarmingAnimalcontroler()
        {//contructor funtion to create a list of animal
            AnimalList = new List<FarmingAnimal>();
        }
        public void Add_Animal(FarmingAnimal animal)
        {//hàm thêm có thông số truyền vào là một đối tượng con vật do mình không biết người
         // ta thêm vào là con gì
            AnimalList.Add(animal);
        }
        public void Remove_Animal(FarmingAnimal animal)
        {
            AnimalList.RemoveAt(0);
        }
        public void Dem_So_Luong()
        {
            if(AnimalList.Count > 0)
            {
               Console.WriteLine($"So luong con {AnimalList[0].Name} trong trai la: {AnimalList.Count}");
            }
            else
            {
                Console.WriteLine("Not thing to show");
            }
        }
        public double TotalAmount_FarmingAnimalcontroler(float weight)
        {//hàm tính tổng tiền thức ăn trên một list con vật
            if (AnimalList.Count>0)
            {
                return AnimalList[0].EatFood.Amout(weight) * AnimalList.Count; ;
            }
            return 0;
        }
        public void PrintsAmount(float weight)
        {
            if (AnimalList.Count > 0)
            {
                Console.WriteLine($"{AnimalList.Count} con {AnimalList[0].Name} an het {AnimalList.Count * weight}kg {AnimalList[0].EatFood.Name_Food}/ngay | chi phi  1 con la: {AnimalList[0].EatFood.Amout(weight)}");
            }
            else
            {
                Console.WriteLine("Not thing to show");
            } 
                
        }

    }
}
