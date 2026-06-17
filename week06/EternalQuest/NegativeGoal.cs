using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Lose points for bad habits
        return -_points;
    }

    public override bool IsComplete()
    {
        // Negative goals never complete
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[-] {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal|{_name}|{_description}|{_points}";
    }
}