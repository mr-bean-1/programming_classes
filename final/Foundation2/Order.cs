

public class Order
{
    private List<Product> _products = new();
    private Customer _customer;  
    private int _inUSA = 5;
    private int _otherCountry = 35;
    private int _shippingCost;
    private float _totalPrice;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void GetShippingLabel()
    {
        Address theAddress = _customer.GetAddress();
        Console.WriteLine("\nShipping label:");
        Console.WriteLine($"Name: {_customer.GetCustomerName()}");
        Console.WriteLine($"{theAddress.DisplayAddressInfo()}");
        _shippingCost = _customer.IsCustomerInUSA() ? _inUSA : _otherCountry;
    }

    public int GetShippingCost()
    {
        return _shippingCost;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("\nPacking label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Item name: {product.GetProductName()} - Item ID: {product.GetProductID()}");
            Console.WriteLine($"Quantity: {product.GetQuantity()}");
        }
    }

    public float CalculateTotalCost()
    {
        foreach (Product product in _products)
        {
            _totalPrice += product.TotalPrice();
        }

        return _totalPrice + GetShippingCost();
    }

    public void AddProduct(Product item)
    {
        _products.Add(item);
    }

    public void DisplayShippingInfo()
    {
        GetPackingLabel();
        GetShippingLabel();
        Console.WriteLine($"\nTotal cost is ${CalculateTotalCost()}\n");
    }
}
