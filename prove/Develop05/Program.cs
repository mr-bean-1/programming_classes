


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Filesave fileSave = new Filesave();
        SaveGoal goalManager = new SaveGoal();
        bool running = true;
   var loadedGoals = fileSave.LoadGoalsFromFile("goals.txt");
        foreach (var goal in loadedGoals)
        {
            goalManager.AddGoal(goal);
        }
        while (running)
        {
            Console.WriteLine("Welcome to the Eternal Quest Goal Setting Program.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Quit");
            Console.WriteLine("\nEnter a number: ");

            string user_input = Console.ReadLine();

            if (user_input == "1")
            {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("\nWhat type of goal would you like to create? ");
                string goal_choice = Console.ReadLine();

                Console.WriteLine("Enter the name of your goal:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the description of your goal:");
                string description = Console.ReadLine();

                Console.WriteLine("Enter the points for this goal:");
                int points = int.Parse(Console.ReadLine());

                if (goal_choice == "1")
                {
                    goalManager.AddGoal(new Simple(name, description, points));
                }
                else if (goal_choice == "2")
                {
                    goalManager.AddGoal(new Eternal(name, description, points));
                }
                else if (goal_choice == "3")
                {
                    Console.WriteLine("How many times does this goal need to be completed?");
                    int timesToComplete = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the bonus points for completing this goal:");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new Checklist(name, description, points, timesToComplete, bonusPoints));
                }
            }
            else if (user_input == "2")
            {
                Console.WriteLine("Listing all goals: ");
                goalManager.DisplayGoals(); 
                Console.WriteLine($"Your total score is {goalManager.GetTotalPoints()} points.");
            }
            else if (user_input == "3")
            {
                Console.WriteLine("Save goals:");
                foreach (var goal in goalManager.GetGoals())
                {
                    Console.WriteLine(goal.SaveGoalInfo());
                }
            }
            else if (user_input == "4")
            {
                Console.WriteLine("Quitting the program.");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }
    }
}







