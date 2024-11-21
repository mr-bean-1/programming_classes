using System.Data;

class Listing{

    public void listing_activity(){

        // listing
        List<string> list_prompts = new List<string>{
            "Who are people that you appreciate?", 
            "What are personal strenghts of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        Console.WriteLine("Welcome to the Listing Activity\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        Console.WriteLine("How long, in seconds, would you like this activity to run? ");
        
        string list_time_input = Console.ReadLine();
        int list_time; 
        // Console.WriteLine("Get ready...");

         if (!int.TryParse(list_time_input, out list_time) || list_time <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        DisplayPrompt(list_prompts);
        CollectResponses(list_time);

    
    }

    public void DisplayPrompt(List<string> prompts){
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        Console.WriteLine(prompts[randomIndex]);

    }
    
   public void CollectResponses(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds); // Calculate end time
        List<string> responses = new List<string>();

        // Start the activity
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a response(s): ");
            string response = Console.ReadLine();

            // If the user presses Enter without entering anything, we stop early
            if (string.IsNullOrEmpty(response))
            {
                break;
            }

            responses.Add(response);
            Console.WriteLine("Response recorded.");
        }

        // Show how many responses were collected
        Console.WriteLine($"\nYou listed {responses.Count} items.\n");
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {seconds} seconds of the Listing Activity!");
        Console.WriteLine("Here are your responses:");
        
        foreach (var response in responses)
        {
            Console.WriteLine($"- {response}");
        }
    }
}


































// }
