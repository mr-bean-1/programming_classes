using System;
using System.Collections.Generic;
//  to exceed requirements the user can memorize a scripture or an article of faith. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the scripture memorization program.");

        // create a list scripture for john 3:16
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life");
        List<Tuple<int, string>> articlesOfFaith = ArticlesOfFaith.GetArticlesOfFaith();        
        Console.WriteLine("\nMemorization Menu:\n");
        Console.WriteLine("1. Scripture (John 3:16)");
        Console.WriteLine("2. Random Article of Faith");
        Console.WriteLine("Enter number:");

        string answer = Console.ReadLine();
        Console.WriteLine("\nPress Enter to continue or type 'quit' to finish the program");

        Scripture currentScripture = null;

        if (answer == "1")
        {
            currentScripture = scripture;
        }
        else if (answer == "2")
        {
            // Randomly select an article of faith
            Random random = new Random();
            var randomArticle = articlesOfFaith[random.Next(articlesOfFaith.Count)];
            currentScripture = new Scripture($"Article of Faith {randomArticle.Item1}", 0, 0, randomArticle.Item2); 
        }
        else
        {
            Console.WriteLine("Wrong number. Try again. ");
            return; // Exit if the input is invalid
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!currentScripture.HideRandomWord())
            {
                Console.WriteLine("You memorized the text!");
                break;
            }

            Console.Clear();
            currentScripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit");
        }
    }
}

