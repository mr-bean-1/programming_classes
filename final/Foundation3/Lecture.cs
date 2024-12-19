public class Lectures : Event
{
    private string _speakerName;
    private int _eventCapacity;

    public Lectures(string speakerName, int eventCapacity, string eventTitle, string description, DateTime date, string time, Address address)
        : base(eventTitle, description, date, time, "Lecture", address)
    {
        _speakerName = speakerName;
        _eventCapacity = eventCapacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}" +
               $"Speaker: {_speakerName}\n" +
               $"Event Capacity: {_eventCapacity}\n";
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(GetFullDetails());
    }
}
