using System;
using System.Threading;

// Common functionality shared by all mindfulness activities
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Set up the activity name and description
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Show information about the activity and get the duration
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Display the ending message when the activity is finished
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    // Simple spinner animation used while waiting
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        // Keep spinning until the time runs out
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Length)
            {
                i = 0;
            }
        }
    }

    // Show a countdown timer on the screen
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    // Allow derived classes to use the activity duration
    protected int GetDuration()
    {
        return _duration;
    }
}