public class Running : Activity
{
    private double _runningSpeed;  

    public Running(string unit, int exerciseDuration, double runningSpeed)
        : base("Running", exerciseDuration, unit)
    {
        _runningSpeed = runningSpeed;
    }

    public override double CalculateDistance()
    {
        if (GetUnit() == "miles")
        {
            return _runningSpeed * GetDuration() / 60.0;  
        }
        return 0;
    }

    public override double CalculateSpeed() => _runningSpeed;  

    public override double CalculatePace() => 60.0 / _runningSpeed;  
}
