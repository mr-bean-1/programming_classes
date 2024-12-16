public class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private string _time;
    private string _eventType;
    private Address _address;

 

    public string GetEventDetails()
    {
        return $"{_eventType} Event\n" +
               $"Event name: {_eventTitle}\n" +
               $"Event Description: {_description}\n" +
               $"Event Date: {_date:MM-dd-yyyy} Time: {_time}\n" +
               $"{_address.DisplayAddressInfo()}\n";
    }


   public Event(string eventTitle, string description, DateTime date, string time, string eventType, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _eventType = eventType;
        _address = address;
    }
    public string GetEventType() => _eventType;
}
