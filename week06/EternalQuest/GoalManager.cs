using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    // Extra requirement: Level system
    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordGoal(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal.");
            return;
        }

        int points = _goals[index].RecordEvent();

        _score += points;

        if (points >= 0)
        {
            Console.WriteLine($"You earned {points} points!");
        }
        else
        {
            Console.WriteLine($"You lost {Math.Abs(points)} points!");
        }

        Console.WriteLine($"Your total score is now {_score}.");
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                Goal goal = new SimpleGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4]));

                _goals.Add(goal);
            }

            else if (type == "EternalGoal")
            {
                Goal goal = new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]));

                _goals.Add(goal);
            }

            else if (type == "ChecklistGoal")
            {
                Goal goal = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[4]),
                    int.Parse(parts[6]));

                _goals.Add(goal);
            }

            else if (type == "NegativeGoal")
            {
                Goal goal = new NegativeGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]));

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public int GoalCount()
    {
        return _goals.Count;
    }
}