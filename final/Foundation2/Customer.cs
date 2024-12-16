public class Customer{
    private string _customerName; 
    private Address _customerAddress;

    public Customer(string name, Address address){
        _customerName = name; 
        _customerAddress = address;
    }

    public bool IsCustomerInUSA(){
        return _customerAddress.IsLocationUsa(_customerAddress.GetCountry());
    }


    public string GetCustomerName(){
        return _customerName;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }
}

// name, address
// getCountry
// getAddress
