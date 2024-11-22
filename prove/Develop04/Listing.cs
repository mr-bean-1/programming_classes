using System; 
using System.Collections.Generic; 

class Listing : Activity {

      List<string> listPrompts = new List<string>{
            "Who are people that you appreciate?", 
            "What are personal strenghts of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };


   protected override void StartActivity(int time)
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("This activity will help you reflect on the good things in your life.");

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        DisplayPrompt();

        CollectResponses(time);
    }
    
    public void DisplayPrompt(){
        Random random = new Random();
        int randomIndex = random.Next(listPrompts.Count);
        Console.WriteLine(listPrompts[randomIndex]);

    }

   private void CollectResponses(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a response: ");
            string response = Console.ReadLine();

            if (string.IsNullOrEmpty(response)) {
                Console.WriteLine("No input detected. ");
                break; 
            }

            responses.Add(response);
            Console.WriteLine("Response recorded.");
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        Console.WriteLine("Well done!! Here are your responses:");
        foreach (var response in responses)
        {
            Console.WriteLine($"- {response}");
        }
    }
}
































// // }
