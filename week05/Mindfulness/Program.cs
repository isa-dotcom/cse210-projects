using System;

/*
Extra feature:
I added a Gratitude Activity to help users focus on positive things
in their lives. This activity was added beyond the project requirements.
*/

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        // Keep showing the menu until the user chooses to quit
        while (choice != "5")
        {
            Console.Clear();

            // Main menu for the mindfulness program
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            // Create and run the selected activity
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
            }
        }
    }
}