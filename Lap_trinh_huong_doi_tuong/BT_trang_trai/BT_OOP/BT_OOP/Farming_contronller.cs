using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP.Base
{
    internal class Farming_contronller
    {
        public Farming_contronller()
        {
            // Tạo ra 4 danh sách con vật 
            Dog = new FarmingAnimalcontroler();
            Cow = new FarmingAnimalcontroler();
            Chicken = new FarmingAnimalcontroler();
            Pig = new FarmingAnimalcontroler();
        }

        #region Properties của mỗi List con vật
        private FarmingAnimalcontroler dog;
        internal FarmingAnimalcontroler Dog
        {
            get { return dog; }
            set { dog = value; }
        }
        private FarmingAnimalcontroler cow;
        internal FarmingAnimalcontroler Cow
        {
            get { return cow; }
            set { cow = value; }
        }
        private FarmingAnimalcontroler chicken;
        internal FarmingAnimalcontroler Chicken
        {
            get { return chicken; }
            set { chicken = value; }
        }
        private FarmingAnimalcontroler pig;
        internal FarmingAnimalcontroler Pig
        {
            get { return pig; }
            set { pig = value; }
        }
        #endregion

        private void Add(FarmingAnimalcontroler animalcontroller, string name, int number)
        {
            FarmingAnimal newAnimal=null;//tạo ra một con vật có giá trị null do chưa biết sẽ thêm vào con nào
            if(name.Equals(Constanst.C_Dog))
            {
                newAnimal = new Dog();//nếu thêm con dog thì dùng con vật đó tạo ra con dog
            }
            else if(name.Equals(Constanst.C_Cow))
            {
                newAnimal = new Cow();
            }
            else if(name.Equals(Constanst.C_Chicken))
            {
                newAnimal = new Chicken();
            }
            else if(name.Equals(Constanst.C_Pig))
            {
                newAnimal = new Pig();
            }
            else
            {
                Console.WriteLine("Con vat khong ton tai!...");
                return;
            }   
            for(int i=0; i<number;i++)//tạo ra danh sách con vật theo số lượng
            {
                animalcontroller.Add_Animal(newAnimal);
            }
        }
        private void Removee(FarmingAnimalcontroler animalcontroller, string name, int number)
        {
            if(animalcontroller.AnimalList.Count>=number)
            {
                FarmingAnimal newAnimal=null;
                if(name.Equals(Constanst.C_Dog))
                {
                    newAnimal = new Dog();
                }
                else if(name.Equals(Constanst.C_Cow))
                {
                    newAnimal = new Cow();
                }
                else if(name.Equals(Constanst.C_Chicken))
                {
                    newAnimal = new Chicken();
                }
                else if(name.Equals(Constanst.C_Pig))
                {
                    newAnimal = new Pig();
                }
                else
                {
                    Console.WriteLine("Con vat khong ton tai!...");
                    return;
                }
                for (int i=0; i<number; i++)
                {
                    animalcontroller.Remove_Animal(newAnimal); 
                }
            }
            else//nếu như số lượng không đủ thì xóa hết 
            {
                Console.WriteLine($"So luong xoa vuot qua danh sach");
                //animalcontroller.AnimalList.Clear();
            }
        }
        public void AddAnimal(string name, int count)
        {
            if (name.Equals(Constanst.C_Dog))
            {
                Add(Dog, Constanst.C_Dog, count);
                return;
            }
            else if (name.Equals(Constanst.C_Cow))
            {
                Add(Cow, Constanst.C_Cow, count);
                return;
            }
            else if (name.Equals(Constanst.C_Chicken))
            {
                Add(Chicken, Constanst.C_Chicken, count);
                return;
            }
            else if (name.Equals(Constanst.C_Pig))
            {
                Add(Pig, Constanst.C_Pig, count);
                return;
            }
            else
            {
                Console.WriteLine("Danh sach con vat khong ton tai");
            }

            //tuong tu
        }
        public void RemoveAnimal(string name, int count)
        {
            if(name.Equals(Constanst.C_Dog))
            {
                Removee(Dog, Constanst.C_Dog, count);
                return;
            }
            else if (name.Equals(Constanst.C_Cow))
            {
                Removee(Cow, Constanst.C_Cow, count);
                return;
            }
            else if (name.Equals(Constanst.C_Chicken))
            {
                Removee(Chicken, Constanst.C_Chicken, count);
                return;
            }
            else if(name.Equals(Constanst.C_Pig))
            {
                Removee(Pig, Constanst.C_Pig, count);
                return;
            }
            else
            {
                Console.WriteLine("Danh sach con vat khong ton tai");
            }
        }
        public void Kiem_Tra_So_Luong( )
        {
            Console.Write("Dog: ");
            Dog.Dem_So_Luong();
            Console.Write("Cow: ");
            Cow.Dem_So_Luong();
            Console.Write("Chicken: ");
            Chicken.Dem_So_Luong();
            Console.Write("Pig: ");
            Pig.Dem_So_Luong();
        }
        public void Sum_TotalAmount()
        {
            Console.WriteLine("\t\tAnimal Dog: ");
            TotalAmount(Dog, Constanst.C_Amount_Meat);
            Console.WriteLine("\t\tAnimal Cow: ");
            TotalAmount(Cow, Constanst.C_Amount_Grass);
            Console.WriteLine("\t\tAnimal Chicken: ");
            TotalAmount(Chicken, Constanst.C_Amount_Corn);
            Console.WriteLine("\t\tAnimal Pig: ");
            TotalAmount(Pig, Constanst.C_Amount_Bran);

            double SUM = Dog.TotalAmount_FarmingAnimalcontroler(Constanst.C_Amount_Meat)
                        +Cow.TotalAmount_FarmingAnimalcontroler(Constanst.C_Amount_Grass)
                        +Chicken.TotalAmount_FarmingAnimalcontroler(Constanst.C_Amount_Corn)
                        +Pig.TotalAmount_FarmingAnimalcontroler(Constanst.C_Amount_Bran);

            Console.WriteLine("\n\t\tTONG CHI PHI CA TRANG TRAI LA: " + SUM);
        }
        private void TotalAmount(FarmingAnimalcontroler name, float weight)//Hàm tính tổng chi phí và xuất ra màn hình thông tin chi phí
        {
            if (name.AnimalList.Count>0)
            {
                double sum = name.TotalAmount_FarmingAnimalcontroler(weight);
                name.PrintsAmount(weight);
                Console.WriteLine($"Tong chi phi tac ca cac con {name.AnimalList[0].Name} an het {name.AnimalList[0].EatFood.Name_Food} la: " + sum.ToString());
            }
            else
            {
                Console.WriteLine("Not thing to show");
            }
        }
        public void Total(string name)//Xuất thông tin chi phí danh sách từng con vật nuôi
        {
            if (name.Equals(Constanst.C_Dog))
            {
                TotalAmount(Dog, Constanst.C_Amount_Meat);
            }
            else if (name.Equals(Constanst.C_Cow))
            {
                TotalAmount(Cow, Constanst.C_Amount_Grass);
            }
            else if (name.Equals(Constanst.C_Chicken))
            {
                TotalAmount(Chicken, Constanst.C_Amount_Corn);
            }
            else if(name.Equals(Constanst.C_Pig))
            {
                TotalAmount(Pig, Constanst.C_Amount_Bran);
            }
        }
    }
}
