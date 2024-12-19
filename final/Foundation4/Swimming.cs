public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(int exerciseDuration, int numberOfLaps)
        : base("Swimming", exerciseDuration) 
    {
        _numberOfLaps = numberOfLaps;
       
    }

public override double CalculateDistance()
    {
        return _numberOfLaps * 50 / 1609.34;
    }

 public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        if (distance == 0) return 0;  
        return distance / GetDuration() * 60.0;  
    }

    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        if (distance == 0) return double.PositiveInfinity;  
        return GetDuration() / distance;  
    }
}
