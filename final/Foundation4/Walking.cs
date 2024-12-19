public class Walking : Activity
{
    private int _walkingSpeed;  

    public Walking(int exerciseDuration, int walkingSpeed)
        : base("Walking", exerciseDuration)
    {
        _walkingSpeed = walkingSpeed;
    }

    public override double CalculateDistance()
    {
        return CalculateBaseDistance(_walkingSpeed);
    }

    public override double CalculateSpeed() => CalculateBaseSpeed(_walkingSpeed);  

    public override double CalculatePace() => CalculateBasePace(_walkingSpeed);
}