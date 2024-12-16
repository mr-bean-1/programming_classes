using System;
public class Simple : Goal
{
    private bool IsCompleted;

    public Simple(string name, string description, int points)
        : base(name, description, points)
    {
        IsCompleted = false;
    }

    public void MarkComplete()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Goal '{Name}' is marked as complete. You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override void DisplayGoalInfo()
    {
        string completionStatus = IsCompleted ? "[X]" : "[]";
        Console.WriteLine($"Simple Goal: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Points: {Points}");
    }

    public override string SaveGoalInfo()
    {
        return $"Simple:{Name}, {Description}, {Points}";
    }
}
