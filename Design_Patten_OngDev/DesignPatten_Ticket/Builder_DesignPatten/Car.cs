using Builder_DesignPatten.CarParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_DesignPatten
{
    internal class Car
    {
        public int NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Corlor { get; set; }
        public Windscreen Windscreen { get; set; }
        public Engine Engine { get; set; }
        public Car(int numberOfWheels, SeatBelt seatBelt, string corlor, Windscreen windscreen, Engine engine)
        {
            NumberOfWheels = numberOfWheels;
            SeatBelt = seatBelt;
            Corlor = corlor;
            Windscreen = windscreen;
            Engine = engine;
        }
        public override string ToString()
        {
            var content = "";
            content += $"Number if Wheels:      \t{NumberOfWheels}\n";
            content += $"Brand of Seat belts:   \t{SeatBelt.Brand}\n";
            content += $"Corlor:                \t{Corlor}\n";
            content += $"Windscreen brand:      \t{Windscreen.Name}\n";
            content += $"Engine:                \t{Engine.Name}\n";
            return content;
        }
    }
}
