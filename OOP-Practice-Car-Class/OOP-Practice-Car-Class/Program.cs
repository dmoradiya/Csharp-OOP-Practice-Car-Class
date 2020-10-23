using System;

namespace OOP_Practice_Car_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Rav4", "Black", 5, 10.00, new Odometer(100), new FuelTank(100,80));

            // Before Drive Method
            Console.WriteLine(car);
            
            car.Drive(350.00);

            // After Drive Method
            Console.WriteLine(car);
            Console.ReadLine();

        }
    }
}
