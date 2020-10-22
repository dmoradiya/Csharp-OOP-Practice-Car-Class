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
        public Odometer KMs { get; set; }

        public FuelTank Tank { get; set; }
        Odometer odometer = new Odometer();
       FuelTank fuelTank = new FuelTank();


        

        public void Drive()
        {
            fuelTank.BurnFuel(20);
            odometer.Increment(20 * FuelEfficiency);
        }

       

        public Car()
        {
            Make = "Toyota";
            Model = "Corolla";
            Color = "Black";
            MaximumOccupancy = 5;
            FuelEfficiency = 10;
            KMs = new Odometer(20 * FuelEfficiency);
            Tank = new FuelTank();
        }
        public override string ToString()
        {
            return $"A {Color} {Make} {Model} with {KMs.Counter}KM on the odometer, that has enough fuel to travel {Tank.Level*FuelEfficiency}KM";
        }

    }
}
