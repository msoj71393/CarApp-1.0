namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static bool MainMenu()
        {
            Trip trip = new Trip();

            bool continueMenu = true;

            while (continueMenu)
            {
                // Display the menu
                Console.Clear(); // Clears the screen before displaying the menu again
                Console.WriteLine($"Main Menu:");
                Console.WriteLine($"1. Add Car");
                Console.WriteLine($"2. Drive");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();

                int choice;

                if (int.TryParse(input, out choice))
                    switch (choice)
                    {
                        case 1:
                            trip.AddCar();
                            break;
                        case 2:
                            trip.Drive();
                            break;
                        case 0:
                            continueMenu = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            return true;
                    }
                    else
                    {
                        // Handle invalid input
                        Console.WriteLine("Invalid input, please enter a number.");
                    }

                    // If the menu should continue, prompt the user
                    if (continueMenu)
                    {
                        Console.WriteLine("\nPress any key to return to the main menu.");
                        Console.ReadKey();
                    }

            }
            return false;
        }
    }
}
