using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System.Security.Cryptography.X509Certificates;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");
            // Create long variable to hold item number
            long itemNumber;
            // Get user input as string and assign to variable.
            string input = Console.ReadLine();
            // Convert user input from string to long and store as item number variable.
            itemNumber = Convert.ToInt32(input);

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    // Break out of loop (since we found what need to)
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number");
            }

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            else
            {
                if (foundAppliance.IsAvailable)
                {
                    foundAppliance.Checkout();
                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has been checked out");
                }

                // Otherwise (appliance isn't available)
                // Write "The appliance is not available to be checked out."
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string brand = Console.ReadLine();



            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();
            // Iterate through loaded appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                {
                    // Add current appliance in list to found list
                    found.Add(appliance);
                }
                // Display found appliances
                DisplayAppliancesFromList(found, 0);
            }


            static void DisplayAppliancesFromList(List<Appliance> appliances, int startIndex)
            {
                // Test found list is empty
                if (appliances.Count == 0)
                {
                    // Write "No appliances found."
                    Console.WriteLine("No appliances found.");
                    return;
                }
                for (int i = startIndex; i < appliances.Count; i++)
                {
                    Console.WriteLine(appliances[i]);
                }

            }
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            Console.WriteLine("Possible options: '0 - Any'\n'2 - Double doors'\n'3 - Three doors'\n'4 - Four doors'");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors
            int numOfDoors = 0;

            // Get user input as string and assign to variable
            string input = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            if (!int.TryParse(input, out numOfDoors) || numOfDoors != 0 && numOfDoors != 2 && numOfDoors != 3 && numOfDoors != 4)
            { 
                Console.WriteLine("Invalid option. Please choose 0, 2, 3 or 4");
                return;
            }

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();
            // Iterate/loop through Appliances
            foreach (Appliance appliance in Appliances) 
            {
                // Test that current appliance is a refrigerator
                // Down cast Appliance to Refrigerator
                // Refrigerator refrigerator = (Refrigerator) appliance;
                if (appliance is Refrigerator refrigerator)
                {
                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (numOfDoors == 0 || refrigerator.Doors == numOfDoors)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }
            }
            
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("Possible options: \n'0 - Any'\n'1 - Residential'\n'2 - Commercial'");

            // Write "Enter grade:"
            Console.WriteLine("Enter grade: ");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            // Return to calling (previous) method
            // return;

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("Possible options: \n'0 - Any'\n'1 - 18 Volt'\n'2 - 24 Volt'");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage: ");
            // Get user input as string
            string voltageInput = Console.ReadLine();  

            // Create variable to hold voltage
            public int voltage = 0;

        // Test input is "0"
        // Assign 0 to voltage
        // Test input is "1"
        // Assign 18 to voltage
        // Test input is "2"
        // Assign 24 to voltage
        // Otherwise
        // Write "Invalid option."
        // Return to calling (previous) method
        // return;

        // Create found variable to hold list of found appliances.

        // Loop through Appliances
        // Check if current appliance is vacuum
        // Down cast current Appliance to Vacuum object
        // Vacuum vacuum = (Vacuum)appliance;

        // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
        // Add current appliance in list to found list

        // Display found appliances
        // DisplayAppliancesFromList(found, 0);


        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"

            // Get user input as string and assign to variable

            // Create character variable that holds room type

            // Test input is "0"
                // Assign 'A' to room type variable
            // Test input is "1"
                // Assign 'K' to room type variable
            // Test input is "2"
                // Assign 'W' to room type variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;

            // Create variable that holds list of 'found' appliances

            // Loop through Appliances
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            // Test input is "0"
                // Assign "Any" to sound rating variable
            // Test input is "1"
                // Assign "Qt" to sound rating variable
            // Test input is "2"
                // Assign "Qr" to sound rating variable
            // Test input is "3"
                // Assign "Qu" to sound rating variable
            // Test input is "4"
                // Assign "M" to sound rating variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method

            // Create variable that holds list of found appliances

            // Loop through Appliances
                // Test if current appliance is dishwasher
                    // Down cast current Appliance to Dishwasher

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                        // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
