using System;
using System.Runtime.CompilerServices;
public class Address{
    private string _address;
    private string _city; 
    private string _state;
    private string _country; 
  
    public Address(string address, string city, string state, string country){
        _address = address;
        _city = city;
        _state = state;
        _country = country; 
    }

    public bool IsLocationUsa(string country){
        return country.ToLower() == "usa";
    }


     public string GetStreetAddress() => _address;
    public string GetCity() => _city;
    public string GetState() => _state;
    public string GetCountry() => _country;

    public string DisplayAddressInfo()
    {
        return $"Street: {GetStreetAddress()}\nCity: {GetCity()}\nState/Province: {GetState()}\nCountry: {GetCountry()}";
    }
}

















// address, city, state, country, postalCode
// getCountry, getAddress
