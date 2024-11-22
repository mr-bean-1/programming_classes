using System; 
using System.Collections.Generic; 

class Reflection : Activity{
  List<string> reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        
        };

         
        List<string> promptReflections = new List<string>{
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

    protected override void StartActivity(int time)
    {
        Console.WriteLine("Welcome to the reflection acticity");
        Console.WriteLine("This activity will help you reflect on times when you have shown strength and resilience.");

        int timeRemaining = time; 

        Console.Clear();
        DisplayRandomPrompt();
        Console.WriteLine("When you have something in mind, press enter. ");
        System.Threading.Thread.Sleep(5000);

        timeRemaining -= 5; 
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(timeRemaining);


        while (DateTime.Now < endTime && promptReflections.Count > 0)
        {
            // Display the prompt
            Console.Clear();
            DisplayFollowUpPrompt(random);
            System.Threading.Thread.Sleep(5000);  
            if (DateTime.Now >= endTime)
            {
                break;
            }
        }

        Console.Clear();
        Console.WriteLine("Reflection activity complete");


        
    }

  private void DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(reflectionPrompts.Count);
        Console.WriteLine(reflectionPrompts[randomIndex]);
    }

    // Method to display a random follow-up prompt from the promptReflections list
    private void DisplayFollowUpPrompt(Random random)
    {
        int randomIndex = random.Next(promptReflections.Count);
        Console.WriteLine(promptReflections[randomIndex]);
    }
}

























