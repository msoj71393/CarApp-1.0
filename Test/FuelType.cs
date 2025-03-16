using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hybrid
    }

    class Fuel
    {

        public void fuelType()
        {
            FuelType fuelType;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Enter fuel type please ");

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty or just white spaces. Please try again.");
                    continue; // Skip the rest of the loop and prompt again
                }

                bool isValidFuel = Enum.TryParse(input, true, out fuelType);

                // Check if the input is valid and corresponds to an actual FuelType
                if (isValidFuel && Enum.IsDefined(typeof(FuelType), fuelType))
                {
                    Console.WriteLine($"You selected: {fuelType}");
                    break; // Exit the loop if the input is valid
                }
                else
                {
                    Console.WriteLine("Invalid fuel type. Please try again.");
                }

            } while (true);
        }
    }


}
