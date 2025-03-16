using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public enum GearType
    {
        Manuel,
        Automatic
    }

    class Gear
    {
        public void gearType()
        {
            GearType gearType;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Enter gear type please ");

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty or just white spaces. Please try again.");
                    continue; // Skip the rest of the loop and prompt again
                }

                bool isValidGear = Enum.TryParse(input, true, out gearType);

                // Check if the input is valid and corresponds to an actual GearType
                if (isValidGear && Enum.IsDefined(typeof(GearType), gearType))
                {
                    Console.WriteLine($"You selected: {gearType}");
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
