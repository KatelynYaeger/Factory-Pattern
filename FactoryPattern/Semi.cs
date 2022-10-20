using System;
namespace FactoryPattern
{
    public class Semi : IVehicle
    {
        public Semi()
        {
        }

        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name} is driving safely!");
        }
    }
}

