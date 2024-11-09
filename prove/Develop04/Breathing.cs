using System.Runtime.CompilerServices;

class Breathing{

    public void breathe_activity(){

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
        Console.WriteLine("How many seconds do you want to breathe?");

        string user_time = Console.ReadLine();






    }
    private void CountDown(){
        for (int i=5; i >0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


     private void CountUp(){
        for (int i=1; i <= 0; i++){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
  

































}
