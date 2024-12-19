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

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}" +
               $"Host: {_hostName}\n" +
               $"Contact: {_hostEmail}\n";
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(GetFullDetails());
    }
}
