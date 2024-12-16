public class Walking : Activity
{
    private int _walkingSpeed;  

    public Walking(string unit, int exerciseDuration, int walkingSpeed)
        : base("Walking", exerciseDuration, unit)
    {
        _walkingSpeed = walkingSpeed;
    }

    public override double CalculateDistance()
    {
        if (GetUnit() == "miles")
        {
            return _walkingSpeed * GetDuration() / 60.0;  
        }
        return 0;
    }

    public override double CalculateSpeed() => _walkingSpeed;  

    public override double CalculatePace() => 60.0 / _walkingSpeed;  
}
