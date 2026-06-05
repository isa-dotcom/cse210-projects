using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity()
        : base(
              "Gratitude Activity",
              "This activity helps you focus on gratitude and positive experiences.")
    {
        _prompts = new List<string>()
        {
            "What are three things you are grateful for today?",
            "Who helped you recently?",
            "What challenge taught you something valuable?",
            "What made you smile this week?"
        };
    }

    // Encourage the user to focus on gratitude
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        // Select a gratitude prompt at random
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        Console.WriteLine();

        // Give the user time to reflect on the prompt
        Console.WriteLine("Take a moment to think...");
        ShowSpinner(GetDuration());

        DisplayEndingMessage();
    }
}