public class Quote
{
    // method GetRandomPrompt 
    // list of all prompts, will give the next prompt to use r
    public static string GetRandomQuote()
    {
        List<string> quotes = new List<string>
        {
            "It is our job to lift other up, not to size them up. - Neal A. Maxwell",
            "It isn't what we say or think that defines us, but what we do. - Jane Austen",
            "How did I help someone else today?",
            "Sometimes by losing a battle, you find a new way to win the war. - Donald Trump",
            "He has a right to criticize, who has a heart to help. - Abraham Lincoln",
            "The best way to predict the future is to create it - Abraham Lincoln",
            "The time is always right to do what is right. - Martin Luther King JR",
        };

        Random random = new Random();
        int index = random.Next(quotes.Count);
        return quotes[index];
    }
}
