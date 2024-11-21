using System;
using System.Formats.Asn1;
// to exceed requirements in the listing class after user lists the program will display their entries. 
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the relaxation program.");
        bool running = true;


        while(running){

            Console.WriteLine("What activity would you like to do? ");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflection activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Enter number: ");
            string user_input = Console.ReadLine();
            Console.WriteLine("\nPress Enter to continue or type quit to finish the program");
            if (user_input == "4"){
                Console.WriteLine("Quitting the program.");
                running = false; 
                break; 
            }

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


            default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
            }

              Console.WriteLine("\nPress Enter to continue or type 'quit' to finish the program.");
            string continueInput = Console.ReadLine().ToLower();

            if (continueInput == "quit")
            {
                running = false;
            }
        }
    }
}




