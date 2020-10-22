using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car_Class
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelEfficiency { get; set; }
        public Odometer Meter { get; set; }

        public FuelTank Tank { get; set; }



        public Car()
        {
            Make = "Toyota";
            Model = "Corolla";
            Color = "Black";
            MaximumOccupancy = 5;
            FuelEfficiency = 10;
            Meter = new Odometer(1000);
            Tank = new FuelTank(100,50);
        }
        public override string ToString()
        {
            return $"A {Color} {Make} {Model} with {Meter}KM on the odometer, that has enough fuel to travel 65KM";
        }

    }
}
