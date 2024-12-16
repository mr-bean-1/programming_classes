


public class Eternal : Goal
{
    public Eternal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void DisplayGoalInfo()
    {
        Console.WriteLine($"Eternal Goal: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Points: {Points}");
    }

    public override string SaveGoalInfo()
    {
        return $"Eternal:{Name}, {Description}, {Points}";
    }
}


