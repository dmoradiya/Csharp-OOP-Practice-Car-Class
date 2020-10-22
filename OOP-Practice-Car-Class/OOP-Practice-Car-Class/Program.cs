using System;

namespace OOP_Practice_Car_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.Write(car);
            Console.WriteLine(car.Tank.Level);
        }
    }
}
