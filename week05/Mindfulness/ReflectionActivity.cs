using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    // Possible prompts for reflection
    private List<string> _prompts;

    // Questions to help the user think deeper
    private List<string> _questions;

    public ReflectionActivity()
        : base(
              "Reflection Activity",
              "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?",
            "What is your favorite thing about this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Run the reflection activity
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        // Choose a random reflection prompt
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.WriteLine("Reflect on the following questions:");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Continue showing questions until time runs out
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.WriteLine();
            Console.Write($"> {question} ");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}