using System;
using System.Transactions;


//  to exceed requirements: 
class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        bool running = true;

        while (running){
        Console.WriteLine("Welcome to the Eternal Quest Goal Setting Program.\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("\nEnter a number: ");

        string user_input = Console.ReadLine();
        Console.WriteLine("\nPress Enter to continue or type quit to finish the program.\n");

            if (user_input == "1"){
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("\nWhat type of goal would you like to create? ");
                string goal_choice = Console.ReadLine();
                
                if (goal_choice == "1"){
                    Console.WriteLine("You chose simple. ");
                    // call to simple file
                }

                if (goal_choice == "2"){
                    Console.WriteLine("You chose eternal. ");
                    // call to eternal file 

                }

                if (goal_choice == "3"){
                    Console.WriteLine("You chose checklist. ");
                    // call to checklist file

                }



            }

             if (user_input == "2"){
                Console.WriteLine("List goals");


            }

             if (user_input == "3"){
                Console.WriteLine("Save goals");

            }

             if (user_input == "4"){
                Console.WriteLine("Load goals");

            }

             if (user_input == "5"){
                Console.WriteLine("Record goals");

            }
//           quit
            if (user_input == "6"){
                Console.WriteLine("Quitting the program.");
                running = false; 
                break; 
            }

            else {
                Console.WriteLine("Invalide number.");
                return; 
            }

       
        }
    }
}








//  requirements 
// Provide for simple goals that can be marked complete and the user gains some value.
// For example, if you run a marathon you get 1000 points.
// Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
// For example, every time you read your scriptures you get 100 points.
// Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
// For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.
// Display the user's score.
// Allow the user to create new goals of any type.
// Allow the user to record an event (meaning they have accomplished a goal and should receive points).
// Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
// Allow the user's goals and their current score to be saved and loaded.


