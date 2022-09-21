using Builder_DesignPatten.CarParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_DesignPatten
{
    internal interface ICarBuilder
    {
        CarBuilder AddWheels(int numberofWheels);
        CarBuilder AddSeatBelt(SeatBelt seatbelt);
        CarBuilder Paint(string color);
        CarBuilder AddWindscreen(Windscreen windscreen);
        CarBuilder AddEngine(Engine engine);
        Car Build();
    }
}
