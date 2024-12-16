class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("239", "San Diego", "California", "USA");
        Address outdoorAddress = new Address("443", "Cheyenne", "Wyoming", "USA");
        Address receptionAddress = new Address("332 GreenBrier Road", "Manti", "Utah", "USA");

        Lectures lecture = new Lectures("James Green", 100, "Training", 
            "Training Meeting for New Hires.", new DateTime(2024, 12, 30), "6:00 AM", lectureAddress);
        lecture.DisplayFullDetails();

        Outdoor outdoor = new Outdoor("44 F Cloudy", "Waterfall Hike", 
            "A day of outdoor activities.", new DateTime(2024, 12, 25), "9:00 AM", outdoorAddress);
        outdoor.DisplayFullDetails();

        Reception reception = new Reception("The Snows", "snow@gmail.com", "Wedding Party", 
            "Celebrate the new coupel!", new DateTime(2025, 5, 12), "8:00 PM", receptionAddress);
        reception.DisplayFullDetails();
    }
}
