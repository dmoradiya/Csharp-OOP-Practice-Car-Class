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
        public double Kilometers { get; set; }
        public double Capacity { get; set; }
        public double Level { get; set; }

        public FuelTank Tank { get; set; }
        Odometer odometer = new Odometer();
        FuelTank fuelTank = new FuelTank();
        
        

        //public void Drive()
        //{
        //    fuelTank.BurnFuel(20);
        //    odometer.Increment(20 * FuelEfficiency);
        //}

        public void Drive(string prompt)
        {
            Console.WriteLine(prompt);
            Kilometers = double.Parse(Console.ReadLine());
            fuelTank.BurnFuel(Kilometers/FuelEfficiency);            
            odometer.Increment(Kilometers);
        }



        

        public Car( string make, string model, string color,int maximumOccupancy, double fuelEfficiency, Odometer kms, FuelTank tank)
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy =maximumOccupancy;
            FuelEfficiency = fuelEfficiency;
            KMs = kms;
            Tank = tank;
        }
        public override string ToString()
        {
            return $"A {Color} {Make} {Model} with {KMs.Counter}KM on the odometer, that has enough fuel to travel {Tank.Level*FuelEfficiency}KM";
        }

    }
}
