using Builder_DesignPatten.CarParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_DesignPatten
{
    internal class CarBuilder:ICarBuilder
    {
        public int NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Corlor { get; set; }
        public Windscreen Windscreen { get; set; }
        public Engine Engine { get; set; }

        public CarBuilder AddEngine(Engine engine)
        {
            Engine = engine;
            return this;
        }

        public CarBuilder AddSeatBelt(SeatBelt seatbelt)
        {
            SeatBelt = seatbelt;
            return this;
        }

        public CarBuilder AddWheels(int numberofWheels)
        {
            NumberOfWheels = numberofWheels;
            return this;
        }

        public CarBuilder AddWindscreen(Windscreen windscreen)
        {
            Windscreen = windscreen;
            return this;
        }


        public CarBuilder Paint(string corlor)
        {
            Corlor = Corlor;
            return this;
        }
        public Car Build()
        {
            return new Car(NumberOfWheels, SeatBelt, Corlor, Windscreen, Engine);
        }

    }
}
