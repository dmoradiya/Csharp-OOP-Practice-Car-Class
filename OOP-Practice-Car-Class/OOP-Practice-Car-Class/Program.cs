using System;

namespace OOP_Practice_Car_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
           
            car.Drive();
            Console.WriteLine(car.Tank.Level);
            Console.Write(car);

        }
    }
}
