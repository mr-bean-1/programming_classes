using System; 
public abstract class Activity{
    public void RunActivity(){
        Console.WriteLine("How long, in seconds, would you like this activity to run? ");
        string timeInput = Console.ReadLine();
        int time; 

        if (!int.TryParse(timeInput, out time) || time <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        StartActivity(time);


    }
    protected abstract void StartActivity(int time);



}
