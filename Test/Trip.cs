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

        double fuelCost { get; set; }
        double distance { get; set; }
        double tripCost { get; set; }

        DateTime tripDate { get; set; }
        DateTime startTime { get; set; }
        DateTime endTime { get; set; }

        public void trip()
        {
            Console.WriteLine($"Enter fuel cost");
            fuelCost = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter fuel efficiency");
            engine.fuelEfficiency = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter trip length");
            distance = double.Parse(Console.ReadLine());

            tripCost = (distance / engine.fuelEfficiency) * fuelCost;
            Console.WriteLine($"Trip cost {tripCost:F2} kr.");

            engine.mileage += distance;
            Console.WriteLine($"New mileage is {engine.mileage}");

        }

        public TimeSpan CalculateDuration()
        {
            TimeSpan tripDuration = endTime - startTime;
            Console.WriteLine(tripDuration.ToString());
            return tripDuration;
        }

        public double CalculateFuelUsed()
        {
            double fuelUsed = distance / engine.fuelEfficiency;
            Console.WriteLine(fuelUsed.ToString());
            return fuelUsed;
        }

        public double CalculateTripPrice(double literPrice)
        {
            double fuelUsed = CalculateFuelUsed();
            double tripPrice = fuelUsed * literPrice;
            Console.WriteLine(tripPrice.ToString());
            return tripPrice;
        }

        public void PrintTripDetails(double literPrice)
        {
            CalculateDuration();
            CalculateFuelUsed();
            CalculateTripPrice(literPrice);
        }
    }
}
