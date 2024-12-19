class Program
{
    static void Main(string[] args)
    {

        // Create Address objects
        Console.Clear();
        Console.WriteLine("Welcome to the Inheritance Program!\n");
        Address lectureAddress = new Address("239", "San Diego", "California", "USA");
        Address outdoorAddress = new Address("443", "Cheyenne", "Wyoming", "USA");
        Address receptionAddress = new Address("332 GreenBrier Road", "Manti", "Utah", "USA");

        // Create event objects
        Lectures lecture = new Lectures("James Green", 100, "Training", 
            "Training Meeting for New Hires.", new DateTime(2024, 12, 30), "6:00 AM", lectureAddress);

        Outdoor outdoor = new Outdoor("44 F Cloudy", "Waterfall Hike", 
            "A day of outdoor activities.", new DateTime(2024, 12, 25), "9:00 AM", outdoorAddress);

        Reception reception = new Reception("The Snows", "snow@gmail.com", "Wedding Party", 
            "Celebrate the new couple!", new DateTime(2025, 5, 12), "8:00 PM", receptionAddress);

// lecture
        Console.WriteLine("Standard Details");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("Full Details");
        lecture.DisplayFullDetails();
        Console.WriteLine("Short Description");
        Console.WriteLine(lecture.GetShortDescription());


// outdoor
        Console.WriteLine("Standard Details");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine("Full Details");
        outdoor.DisplayFullDetails();
        Console.WriteLine("Short Description");
        Console.WriteLine(outdoor.GetShortDescription());


// reception
        Console.WriteLine("Standard Details");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("Full Details");
        reception.DisplayFullDetails();
        Console.WriteLine("Short Description");
        Console.WriteLine(reception.GetShortDescription());
    }
}





