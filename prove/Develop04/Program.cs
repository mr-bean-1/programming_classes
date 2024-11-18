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


// breathing activity
        switch (user_input){
            case "1":
            Breathing breathingActivity = new Breathing();
            breathingActivity.breathe_activity();
            break; 
        
// reflection activity
            case "2":
          
            Reflection reflection = new Reflection();
            reflection.reflection_activity();

            break; 

// listing activity
        case "3":
      
            Listing listing = new Listing();
            listing.listing_activity();
          

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
                user_input = Console.ReadLine(); 
            }
        }
    }
}




