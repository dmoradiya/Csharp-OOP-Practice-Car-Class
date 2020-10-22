using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car_Class
{
    class FuelTank
    {
        private double _capacity;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;

            }
        }

        private double _level;
        public double Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;

            }
        }


        public FuelTank(double capacity, double level)
        {
            Capacity = capacity;
            Level = level;
        }
    }
}
