using System.Security.Cryptography.X509Certificates;

class Reflection{
    public void reflection_activity(){
        // reflection
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. THis will help yo urecognize the power you have and how you can use it in other aspects of your life");
        
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


        

        // Random random = new Random();
        // int index = random.Next(reflection_prompts.Count);
        // int index = random.Next(prompt_reflections.Count);
        
        // return reflection_prompts[index];
        // return prompt_reflections[index];


    }
    public void DisplayPrompt(){
        int randomIndex = new Random().Next(0, _reflection_prompts.Count());
        Console.WriteLine(_reflection_prompts[randomIndex]);
    }


   public void DisplayQuestions()
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            int randomInt = new Random().Next(0, _prompt_reflections.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _prompt_reflections.Count());
            }
            indexes.Add(randomInt);
        }





























}
