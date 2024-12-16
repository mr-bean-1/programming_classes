public class Reception : Event
{
    private string _hostName;
    private string _hostEmail;

    public Reception(string hostName, string hostEmail, string eventTitle, string description, DateTime date, string time, Address address)
        : base(eventTitle, description, date, time, "Reception", address)
    {
        _hostName = hostName;
        _hostEmail = hostEmail;
    }


 public void DisplayFullDetails()
    {
        Console.WriteLine(GetReceptionDetails());
    }
    public string GetReceptionDetails()
    {
        return $"{GetEventDetails()}" +
               $"Host: {_hostName}\n" +
               $"Contact: {_hostEmail}\n";
    }

   
}
