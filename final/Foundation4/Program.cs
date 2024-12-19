class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the exercise calculation program!");

        List<Activity> activities = new();

        Running running = new(15, 3);   
        activities.Add(running);

        Cycling cycling = new(55, 20); 
        activities.Add(cycling);

        Swimming swimming = new(20, 18);  
        activities.Add(swimming);

        Walking walking = new(120, 5);  
        activities.Add(walking);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}
