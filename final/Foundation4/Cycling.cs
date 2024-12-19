public class Cycling : Activity
{
    private int _cyclingSpeed;

    public Cycling( int exerciseDuration, int cyclingSpeed)
        : base("Cycling", exerciseDuration)
    {
        _cyclingSpeed = cyclingSpeed;
    }

    public override double CalculateDistance()
    {
        return CalculateBaseDistance(_cyclingSpeed);
    }

    public override double CalculateSpeed() => CalculateBaseSpeed(_cyclingSpeed);

    public override double CalculatePace() => CalculateBasePace(_cyclingSpeed);
}