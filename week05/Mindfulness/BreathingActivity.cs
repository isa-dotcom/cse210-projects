using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
              "Breathing Activity",
              "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Guide the user through breathing in and out
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Continue breathing until the activity duration is reached
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();

            // Breathe in slowly
            Console.Write("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine();

            // Breathe out slowly
            Console.Write("Breathe out...");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}