using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Trip
    {
        GearType gearType = new GearType();
        FuelType fuelType = new FuelType();
        
        Engine engine = new Engine();
        Fuel fuel = new Fuel();
        Gear gear = new Gear();

        private List<Car> cars = new List<Car>(); // List to store multiple cars

        double fuelEfficiency { get; set; }
        double fuelCost { get; set; }
        double distance {  get; set; }
        double tripCost { get; set; }

        public void AddCar()
        {
            Console.WriteLine("Would you like to add a car? (y/n)");
            string addCarInput = Console.ReadLine().ToLower();

            while (addCarInput == "y")
            {
                Car newCar = new Car("", "", "", 0, engine, fuelType, gearType);
                newCar.car();  // Get details for the new car
                cars.Add(newCar);  // Add car to the list

                Console.WriteLine("Car added successfully!");

                Console.WriteLine("Would you like to add another car? (y/n)");
                addCarInput = Console.ReadLine().ToLower();
            }
            
            Console.WriteLine($"Would you like to add fuel type? (y/n)");
            string addFuelType = Console.ReadLine().ToLower();

            while (addFuelType == "y")
            {
                // After adding cars, you can proceed to fuel selection and driving
                fuel.fuelType();

                Console.WriteLine($"Would you like to add fuel type? (y/n)");
                addFuelType = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Would you like to add gear type? (y/n)");
            string addGearType = Console.ReadLine().ToLower();

            while (addGearType == "y")
            {
                // After adding cars, you can proceed to gear selection and driving
                gear.gearType();

                Console.WriteLine($"Would you like to add gear type? (y/n)");
                addGearType = Console.ReadLine().ToLower();
            }

            // Optionally, display all cars
            Console.WriteLine("\nList of cars added:");
            foreach (var car in cars)
            {
                car.DisplayCarDetails();
            }
        }

        public void Drive()
        {
            Console.WriteLine($"Would you like to start the car? (y/n)");
            string isEngineOn = Console.ReadLine().ToLower();

            if (isEngineOn == "y")
            {
                engine.engineOn();
                Console.WriteLine($"The engine has started");
            }
            if (isEngineOn == "n")
            {
                engine.engineOff();
                Console.WriteLine($"The engine has stopped");
                return; //This will quit the method back to the mainmenu().
            }

            // This selects which car you drive.
            Console.WriteLine("Select a car to drive:");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].make} {cars[i].model}");
            }
            int carChoice = int.Parse(Console.ReadLine()) - 1;
            Car selectedCar = cars[carChoice];

            trip();
        }

        public void trip()
        {
            Console.WriteLine($"Enter fuel cost");
            fuelCost = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter fuel efficiency");
            fuelEfficiency = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter trip length");
            distance = double.Parse(Console.ReadLine());

            tripCost = (distance / fuelEfficiency) * fuelCost; 
            Console.WriteLine($"Trip cost {tripCost:F2} kr.");

            engine.mileage += distance;
            Console.WriteLine($"New mileage is {engine.mileage}");

        }
    }
}
