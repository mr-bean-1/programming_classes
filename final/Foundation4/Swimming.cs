public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string unit, int exerciseDuration, int numberOfLaps)
        : base("Swimming", exerciseDuration, unit) 
    {
        _numberOfLaps = numberOfLaps;
       
    }

    public override double CalculateDistance()
    {
        if (GetUnit() == "km")
        {
            return _numberOfLaps * 50 / 1000;
        }
        else if (GetUnit() == "miles")
        {
            return _numberOfLaps * 50 / 1000 * 0.62;
        }
        return 0;
    }

     public override double CalculateSpeed() => (CalculateDistance() / GetDuration()) * 60.0;

    public override double CalculatePace() => GetDuration() / CalculateDistance();
}
