public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private string[] _months = 
    {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
    private int _duration;
    private string _name;
    private string _unit = "miles"; 

    public Activity(string name, int duration, string unit = "miles")  
    {
        _name = name;
        _duration = duration;
        _unit = unit;
    }
 public virtual void GetSummary()
    {
        string dateFormat = $"{_date.Day} {_months[_date.Month - 1]} {_date.Year}";
        string summary = $"{dateFormat} {GetName()} ({GetDuration()} min): " +
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

   
}
