
public class Product
{
    private string _productName;
    private string _productID;
    private float _price;
    private int _quantity;

    public Product(string name, string productID, float price, int quantity)
    {
        _productName = name; 
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName() => _productName;
    public string GetProductID() => _productID;
    public float GetPrice() => _price; 
    public int GetQuantity() => _quantity;
    public float TotalPrice() => _price * _quantity;




}