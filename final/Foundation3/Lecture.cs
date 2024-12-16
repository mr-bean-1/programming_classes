public class Lectures : Event
{
    private string _speakerName;
    private int _eventCapacity;


  public string GetLectureDetails()
    {
        return $"{GetEventDetails()}" +
               $"Speaker: {_speakerName}\n" +
               $"Event capacity: {_eventCapacity}\n";
    }
    public Lectures(string speakerName, int eventCapacity, string eventTitle, string description, DateTime date, string time, Address address)
        : base(eventTitle, description, date, time, "Lectures", address)
    {
        _speakerName = speakerName;
        _eventCapacity = eventCapacity;
    }

  

    public void DisplayFullDetails()
    {
        Console.WriteLine(GetLectureDetails());
    }
}
