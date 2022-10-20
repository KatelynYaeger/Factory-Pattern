using System;
namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name} is driving fast!");
        }
    }
}

