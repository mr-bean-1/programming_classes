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

           Activity activity = user_input switch
            {
                "1" => new Breathing(),
                "2" => new Reflection(),
                "3" => new Listing(),
                _ => null
            };

            if (activity != null)
            {
                activity.RunActivity();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}














