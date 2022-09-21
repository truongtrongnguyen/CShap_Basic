using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_inversion_DI
{
    internal class Demo1
    {
        public void Demo()
        {
            Horn horn = new Horn(2);
            Car car = new Car(horn);//inject bằng phương thức khởi tạo
            //car.horn = horn;//Inject bằng phương thức setter và có thể inject bằng phương thức interface
            car.Beep();
        }
    }
    public class Horn
    {
        public int lever = 0;//độ lớn của còi xe
        public Horn(int _lever)//Lúc này ta thêm vào độ lớn của còi xe cũng không ảnh hưởng gì đến lớp Car mà chỉ cần sữa code liên quan đến lớp Horn
        {
            lever = _lever;
        }
        public void Beep()
        {
            Console.WriteLine("Beep...Beep...Beep...");
        }
    }
    public class Car
    {
        //tạo một đối tượng còi xe để nếu lớp Còi xe mà có thay đổi cũng không ảnh hưởng gì đến lớp Car
        public Horn horn { get; set; }//Lớp Horn là Dependency được đưa từ bên ngoài vào cho thấy linh hoạt hơn so với phải tạo một đối tượng Horn trong Lớp Car
        public Car(Horn _hor)//Cách này được gọi là inject bằng phương thức khởi tạo
        {
            horn = _hor;
        }
        public void Beep()
        {
            horn.Beep();
        }
    }
}
