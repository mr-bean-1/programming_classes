
public class Checklist : Goal
{
    private int TimesToComplete;
    private int BonusPoints;
    private int CompletedTimes;

    public Checklist(string name, string description, int points, int timesToComplete, int bonusPoints)
        : base(name, description, points)
    {
        this.TimesToComplete = timesToComplete;
        this.BonusPoints = bonusPoints;
        this.CompletedTimes = 0;
    }

    public void MarkComplete()
    {
        if (CompletedTimes < TimesToComplete)
        {
            CompletedTimes++;
            Console.WriteLine($"You earned {Points} points for this completion.");
            if (CompletedTimes == TimesToComplete)
            {
                Console.WriteLine($"You've earned a bonus of {BonusPoints} points!");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is fully completed.");
        }
    }

    public override void DisplayGoalInfo()

    {
        string completionStatus = CompletedTimes == TimesToComplete ? "[X]" : "[ ]";
        Console.WriteLine($"Checklist Goal: {Name} (Completed: {CompletedTimes}/{TimesToComplete})");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Points per completion: {Points}");
        if (CompletedTimes == TimesToComplete)
        {
            Console.WriteLine($"Bonus points: {BonusPoints}");
        }
    }

    public override string SaveGoalInfo()
    {
        return $"Checklist:{Name}, {Description}, {Points}, {TimesToComplete}, {BonusPoints}";
    }
}
