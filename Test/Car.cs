using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Car
    {
        GearType gearType = new GearType();
        FuelType fuelType = new FuelType();

        Engine engine = new();
        public string owner { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public double year { get; set; }
        
        public Car(string owner, string make, string model, double year, Engine engine, FuelType fuelType, GearType gearType)
        {
            this.owner = owner;
            this.make = make;
            this.model = model;
            this.year = year;
            this.engine = engine;
            this.fuelType = fuelType;
            this.gearType = gearType;
        }

        public void car()
        {
            Console.WriteLine($"Enter owner name ");
            owner = Console.ReadLine();

            Console.WriteLine($"Enter make name ");
            make = Console.ReadLine();

            Console.WriteLine($"Enter model name ");
            model = Console.ReadLine();

            Console.WriteLine($"Enter year ");
            year = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter mileage ");
            engine.mileage = double.Parse(Console.ReadLine());
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine($"Owner: {owner}, Make: {make}, Model: {model}, Year: {year}, Mileage: {engine.mileage}, Fueltype: {fuelType}, Geartype: {gearType}");
        }

    }
}
