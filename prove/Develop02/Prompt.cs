using System;
using System.Collections.Generic;

public class Prompt
{
    // method GetRandomPrompt 
    // list of all prompts, will give the next prompt to use r
    public static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "How did I help someone else today?",
            "What went well today, and what didn't go well?",
            "What did I learn today?",
            "What is my favorite memory from my childhood?",
            "What do I want to accomplish in the next 5 years?",
            "What is a goal I want to set?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
