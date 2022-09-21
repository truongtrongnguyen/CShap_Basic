using Builder_DesignPatten.CarParts;
using System;

namespace Builder_DesignPatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=hcA7cT0_BeE&list=PLoaAbmGPgTSOrVuxwbnDJ14U9J6CXJXUk&index=14
            //Chỉ nên sử dụng Builder DesignPatten khi có số lượng lớn input và data phức tạp
            // Builder DesignPatten sẽ giúp việc đọc code trở nên dễ dàng hơn rất nhiều
            // Builder DesignPatten sẽ giúp ta chia nhỏ constructor ra thành nhiều phần nhỏ hơn và 
            // cho chúng ta 1 khả năng khởi tạo một object thành nhiều hướng khác nhau

            var car = new Car(4, new SeatBelt("OngDev"),
                                "Red",
                                new Windscreen("OngDev"),
                                new Engine("Foot"));

            // Do Kiểu trả về là một CarBuilder nên ta có thể truy cập đến đối tượng tiếp theo trong lớp CarBuilder
            
            var carByBuilder = new CarBuilder().AddWheels(4)
                                             .AddSeatBelt(new SeatBelt("Ong Dev Seat Belt"))
                                             .AddWindscreen(new Windscreen("Ong Dev Wind screen"))
                                             .AddEngine(new Engine("Ong Dev Foot"))
                                             .Paint("Red")
                                             .Build();

            Console.WriteLine(car);
            Console.WriteLine("===================================");
            Console.WriteLine(carByBuilder);

            Console.ReadKey();
        }
    }
}
