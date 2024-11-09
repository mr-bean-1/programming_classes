class Listing{

    public void listing_activity(){

        // listing
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        List<string> list_prompts = new List<string>{
            "Who are people that you appreciate?", 
            "What are personal strenghts of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        Random random = new Random();
        int index = random.Next(listing_activity.Count);
        return listing_activity[index];



    }































}
