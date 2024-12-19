public abstract class Activity
{
    private DateTime _date = DateTime.Now;
   
    private int _duration;
    private string _name;
    private string _unit = "miles"; 

    public Activity(string name, int duration)  
    {
        _name = name;
        _duration = duration;
    }

    public virtual void GetSummary()
    {
        string summary = $" {GetName()} ({GetDuration()} min): " +
                         $"Distance {CalculateDistance():0.0} {GetUnit()}, " +
                         $"Speed {CalculateSpeed():0.0} {GetUnit()}/h, " +
                         $"Pace {CalculatePace():0.0} min per {GetUnit()}";
        Console.WriteLine(summary);
    }

    public string GetName() => _name;
    protected int GetDuration() => _duration;
    public string GetUnit() => _unit;

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    protected double CalculateBaseDistance(int speed)
    {
        return speed * GetDuration() / 60.0;
    }

    protected double CalculateBaseSpeed(int speed)
    {
        return speed;
    }

    protected double CalculateBasePace(int speed)
    {
        return 60.0 / speed;
    }
}