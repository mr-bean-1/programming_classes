using System;

public class Program
{
    static void Main(string[] args)
    {
        // created a filepath for user to enter journal into as well as adding and loading it 
        Journal journal = new Journal();
        string filePath = "journal-entries.txt";
        journal.LoadFromFile(filePath);
        journal.AddEntry("Sample prompt", "Sample Response");
        journal.SaveToFile(filePath);

        bool running = true; 
        Console.WriteLine("Welcome to the Journal Program");
    

    while (running){
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        string answer = Console.ReadLine();
       

// used a switch statment to execute whatever number the user entered
// write switch
        switch (answer){
                case "1":
                    Console.WriteLine("Your choice is 1");
                    string prompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);  
                    break; 
// display switch
            case "2":
               Console.WriteLine("Your choice is 2");
               journal.DisplayEntries();


            break; 
// load file switch
            case "3":
               Console.WriteLine("Your choice is 3");
               Console.Write("Enter the file to be loaded: ");
               string loadFileName = Console.ReadLine();
               journal.LoadFromFile(loadFileName);
               Console.WriteLine("Jourlan loaded.");


            break; 
// save file switch
            case "4":
                Console.WriteLine("Your choice is 4");
                Console.Write("Enter the file name to save: ");
                string saveFileName = Console.ReadLine(); 
                journal.SaveToFile(saveFileName);
                Console.WriteLine("Entry saved.");


            break; 
// quit program switch 
            case "5":
            running = false; 
            break;

        }


        }

    }
}
             


















