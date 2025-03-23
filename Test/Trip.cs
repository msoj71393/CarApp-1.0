using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    public class Trip
    {
        Engine engine = new Engine();

        double fuelEfficiency { get; set; }
        double fuelCost { get; set; }
        double distance { get; set; }
        double tripCost { get; set; }

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
