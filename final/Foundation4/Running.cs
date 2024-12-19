public class Running : Activity
{
    private double _runningSpeed;  

    public Running(int exerciseDuration, double runningSpeed)
        : base("Running", exerciseDuration)
    {
        _runningSpeed = runningSpeed;
    }

    public override double CalculateDistance()
    {
       
           return CalculateBaseDistance((int)_runningSpeed);
        
    }

   public override double CalculateSpeed() => CalculateBaseSpeed((int)_runningSpeed);  // Use the base method

    public override double CalculatePace() => CalculateBasePace((int)_runningSpeed);  // Pace based on miles per hour
}
