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


    }
}
