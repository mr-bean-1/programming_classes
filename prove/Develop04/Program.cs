using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the relaxation program.");
        Console.WriteLine("What activity would you like to do? ");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Enter number: ");
        string user_input = Console.ReadLine();
        Console.WriteLine("\nPress Enter to continue or type quit to finish the program");
        bool running = true;


        while(running){

        switch (user_input){
            case "1":
            // Random random = new Random(); 
            // breathing.breathe_activity();
            Console.WriteLine("Starting breathing activity.");
            break; 
        

            case "2":
            // Random random = new Random(); 

            // reflection.reflection_activity();
            // Reflection.prompt_reflections();
            Console.WriteLine("Starting reflection activity.");

            break; 

    
        case "3":
      
            // Random random = new Random(); 
            // Listing.listing_activity();
            Console.WriteLine("Starting breathing activity.");

            break; 

        
        case "4":
                    Console.WriteLine("Quitting the program...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to continue or type quit to finish the program");
                user_input = Console.ReadLine();  // Update user_input after each loop
            }
        }
    }
}




