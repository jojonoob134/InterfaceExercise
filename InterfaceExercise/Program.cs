using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            var suv = new SUV() { Name = "2018 Alfa Romeo Stelvio Sport", Color = "blue", Speed = 60, NumOfWheels = 4, NumOfSeats = 6, CanGoOffRoud = true  };

            var truck = new Truck() { Name = "Ford F750", Color = "white", SizeOfTruck = "beg", Speed = 70, SizeOfBed = 15, NumOfWheels = 4 };

            var car = new Car() { Name = "Toyota Prius 4", Color = "red", Speed = 80, GasMileage = 14, HasScrean = true, NumOfWheels = 4 };

            List<IVehicle> transportation = new List<IVehicle>();
            transportation.Add(car);
            //Creatively display and organize their values
            foreach (var vehicle in transportation)
            {
                Console.WriteLine($"The name of the car is {vehicle.Name}");
                Console.WriteLine($"The color of this vehicle is {vehicle.Color}");
                Console.WriteLine($"This vehicle can go up to {vehicle.Color} MPH");
                Console.WriteLine($"This car has {vehicle.NumOfWheels} number of wheels");
            }
        }
    }
}
