public class Addressthree
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


public string DisplayAddressInfo()
    {
        return $"Street: {_street}\nCity: {_city}\nState/Province: {_state}\nCountry: {_country}";
    }
    public Address(string street, string city, string state, string country)
    {
        _street= street;
        _city = city;
        _state = state;
        _country = country;
    }


}
