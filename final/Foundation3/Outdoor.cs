public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string weatherForecast, string eventTitle, string description, DateTime date, string time, Address address)
        : base(eventTitle, description, date, time, "Outdoor", address)
    {
        _weatherForecast = weatherForecast;
    }

    public string Weather()
    {
        return $"{GetEventDetails()}" +
               $"Weather Forecast : {_weatherForecast}\n";
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine(Weather());
    }
}