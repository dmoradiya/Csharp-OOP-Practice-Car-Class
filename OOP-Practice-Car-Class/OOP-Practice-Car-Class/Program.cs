using System;

namespace OOP_Practice_Car_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Rav4", "Black", 5, 10.00, new Odometer(1000), new FuelTank(100,50));


            Console.WriteLine(car);
            car.Drive("Please Enter how many Kilometer You want to drive");
            Console.WriteLine(car.Tank.Level);
            Console.WriteLine(car);

        }
    }
}
