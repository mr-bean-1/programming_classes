class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Encapsulation Shipping program!");

        Address address1 = new Address("1600 Pennsylvania Avenue NW", "Washington DC", "Virginia", "United States");
        Customer customer1 = new Customer("Yasmin Hayes", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("Chocolate bar", "1", 1.13f, 5); 
        Product product2 = new Product("First Aid Kit", "2", 20.33f, 2);  

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order1.DisplayShippingInfo();
    }
}
