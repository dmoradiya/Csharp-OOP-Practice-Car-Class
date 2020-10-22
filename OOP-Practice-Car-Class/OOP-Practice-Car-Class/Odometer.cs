using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car_Class
{
    class Odometer
    {
        private double _counter;
        public double Counter
        {
            get
            {
                return _counter;
            }
            set
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


        public Odometer(double counter)
        {
            Counter = counter;
        }
    }
}
