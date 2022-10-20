using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {

            switch (wheelCount)
            {
                case 18:
                    return new Semi();
 
                case 4:
                    return new Car();
     
                case 2:
                    return new Motorcycle();

                default:
                    return new Car();
            }


        }

    }
}

