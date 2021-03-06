﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car_Class
{
    public class FuelTank
    {
        private double _capacity;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            private set
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
            private set
            {
                if( value < 0 )
                {
                    throw new Exception("Fuel is empty.");
                }
                else if( value > Capacity )
                {
                    _level = Capacity;
                }
                else
                {
                    _level = value;
                }
                

            }
        }
        
         public void BurnFuel(double Liters)
         {
            Level -= Liters;
         }

        public void Fill(double Liters)
        {
            Level += Liters;
        }

        public FuelTank()
        {
            Capacity = 50;
            Level = 50;
        }

        public FuelTank(double capacity, double level)
        {
            Capacity = capacity;
            Level = level;
        }
    }
}
