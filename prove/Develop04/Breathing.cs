using System.Runtime.CompilerServices;
using System; 

class Breathing{

    public void breathe_activity(){

        Console.WriteLine("Welcome to the breathing activity.");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
        Console.WriteLine("How long, in seconds, would you like to breathe for your session? ");
        
        string user_time_input = Console.ReadLine();
        int user_time; 

        // make it run for user's time 
        // breathe in for 4 seconds
        // breathe out for 6 seconds

        if (!int.TryParse(user_time_input, out user_time) || user_time <= 0){
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return; 
    }
    Console.WriteLine($"breathing in for {user_time} seconds.");
    int cycles = user_time / 8; 

    for (int cycle =1; cycle <= cycles; cycle ++){
        Console.WriteLine("Breathe in...");
        CountDown(4);
        Console.WriteLine("Breathe out...");
        CountDown(4);

    }
    Console.WriteLine("you finished the activity. ");

    }


  
    private void CountDown(int seconds){
        for (int i= seconds; i >0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

  

































}
