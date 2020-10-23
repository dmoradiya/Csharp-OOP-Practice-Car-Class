using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car_Class
{
    public class Odometer
    {
        private double _counter;
        public double Counter
        {
            get
            {
                return _counter;
            }
            private set
            {
                if( value > 999999)
                {
                    _counter = value - 999999;

                }
                else
                {
                    _counter = value;
                }              

            }
        }
       
        public void Increment(double amount)
        {
            Counter += amount;
        }
        

        public Odometer()
        {
            Counter = 0;
        }
        public Odometer(double counter)
        {
            Counter = counter;
        }
    }
}
