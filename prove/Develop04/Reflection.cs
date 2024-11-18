using System.Security.Cryptography.X509Certificates;

class Reflection{

        List<string> reflection_prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        
        };
    


        List<string> prompt_reflections = new List<string>{
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started", 
            "How did you feel when it was complete?",
            "What made this tiem different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    public void reflection_activity(){
        // reflection
    
        Console.WriteLine("Welcome to the reflecting activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. THis will help yo urecognize the power you have and how you can use it in other aspects of your life");
        Console.WriteLine("How long, in seconds, do you want this activity to run?");
        string reflection_seconds_input = Console.ReadLine();
        int reflection_seconds;
        
        if (!int.TryParse(reflection_seconds_input, out reflection_seconds) || reflection_seconds <= 0){
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return; }
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();

        int timeRemaining = reflection_seconds - 10; 
        CountDown(10);

        Random random = new Random();
        while (timeRemaining > 0){
            DisplayQuestion(random);
            timeRemaining -= 5; 
            CountDown(5);
        }
        Console.WriteLine("Reflection activity complete.");


    }
    public void DisplayPrompt(){
        Random random = new Random();
        int randomIndex = random.Next(reflection_prompts.Count);

        Console.WriteLine(reflection_prompts[randomIndex]);
    }


   public void DisplayQuestion(Random random)
    { 
        int randomIndex = random.Next(prompt_reflections.Count);
        Console.WriteLine(prompt_reflections[randomIndex]);

    }


  private void CountDown(int seconds){
        for (int i= seconds; i >0; i--){
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }





















}







