using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car_Class
{
    public class Car
    {
       

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelEfficiency { get; set; }
        public Odometer KMs { get; set; }
        public FuelTank Tank { get; set; }
        //odometer odometer = new odometer();
        //fueltank fueltank = new fueltank();



        public void Drive()
        {
            Tank.BurnFuel(20/FuelEfficiency);
            KMs.Increment(20);
        }

        public void Drive(double distance)
        {
            
            Tank.BurnFuel(distance/FuelEfficiency);            
            KMs.Increment(distance);
        }

        // Default Constructor
        public Car()
        {
            Make = "Honda";
            Model = "CRV";
            Color = "White";
            MaximumOccupancy = 5;
            FuelEfficiency = 9.5;
            KMs = new Odometer();
            Tank = new FuelTank(); 
        }
        
        // Greedy Constructor
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
