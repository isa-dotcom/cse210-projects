// Exceeded requirements:
// Added Negative Goals that remove points.
// Added a level system based on score.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeded requirements:
        // Added a Negative Goal that removes points.
        // Added a level system based on total score.

        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine($"Level: {manager.GetLevel()}");
            Console.WriteLine();

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal(manager);
                    break;

                case 2:
                    manager.DisplayGoals();
                    Pause();
                    break;

                case 3:
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();

                    manager.SaveGoals(saveFile);
                    Pause();
                    break;

                case 4:
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();

                    manager.LoadGoals(loadFile);
                    Pause();
                    break;

                case 5:
                    if (manager.GoalCount() == 0)
                    {
                        Console.WriteLine("No goals available.");
                        Pause();
                        break;
                    }

                    manager.DisplayGoals();

                    Console.Write("\nWhich goal did you accomplish? ");
                    int goalNumber = int.Parse(Console.ReadLine());

                    manager.RecordGoal(goalNumber - 1);

                    Pause();
                    break;

                case 6:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Pause();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");

        Console.Write("Choose a type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (type == 1)
        {
            goal = new SimpleGoal(name, description, points);
        }

        else if (type == 2)
        {
            goal = new EternalGoal(name, description, points);
        }

        else if (type == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus);
        }

        else if (type == 4)
        {
            goal = new NegativeGoal(
                name,
                description,
                points);
        }

        if (goal != null)
        {
            manager.AddGoal(goal);
            Console.WriteLine("Goal created!");
        }

        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}