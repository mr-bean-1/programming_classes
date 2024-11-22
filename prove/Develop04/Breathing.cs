using System.Runtime.CompilerServices;
using System; 

class Breathing : Activity{

    protected override void StartActivity(int time)
    {
        Console.WriteLine("Welcome to the breathing activity.");
        Console.WriteLine("\nThis activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
        int cycles = time / 8; 

          for (int cycle =1; cycle <= cycles; cycle ++){
                Console.WriteLine("Breathe in...");
                CountDown(4);
                Console.WriteLine("Breathe out...");
                CountDown(4);
                Console.WriteLine();
          }
        
        Console.WriteLine("Well done!!");
       Console.WriteLine($"You have completed another {time} seconds of the Breathing activity. ");


    }

    private void CountDown(int seconds){
        for (int i = seconds; i > 0; i--){
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}
