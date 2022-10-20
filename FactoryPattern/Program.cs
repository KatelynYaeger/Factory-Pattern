namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("How many wheels would you like?");

            int wheelCount;

            var answer = int.TryParse(Console.ReadLine(), out wheelCount);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);

            vehicle.Drive();
        }
    }
}


//DONE - Create an Interface named IVehicle that has a stubbed out public void Drive method

//DONE - Create 2 new public classes that will conform to IVehicle:
//DONE - Examples: Car, Truck, Motorcycle, BigRig,  SUV
//DONE - These 2 classes must implement the Drive method

//DONE - Create a static VehicleFactory class:
//DONE - Add a GetVehicle method that will return an IVehicle based on the amount of tires it’s given as a parameter:
//DONE - Make the method static
//DONE - A return type of IVehicle
//DONE - 1 string parameter

//DONE - Call this method in your Main method

