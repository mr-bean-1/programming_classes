class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Encapsulation Shipping program!");
        Console.Clear();

        Address address1 = new Address("1600 Pennsylvania Avenue NW", "Washington DC", "Virginia", "United States");
        Customer customer1 = new Customer("Yasmin Hayes", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("Chocolate bar", "1", 1.13f, 5); 
        Product product2 = new Product("First Aid Kit", "2", 20.33f, 2);  

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order1.DisplayShippingInfo();
        // Av. Gustave Eiffel, 75007 Paris, France


        Address address2 = new Address("Av. Gustave Eiffel", "", "Paris", "France");
        Customer customer2 = new Customer ("Hercule Poroit", address2);

        Order order2 = new Order(customer2);

        Product product3 = new Product("Baguette", "3", 4.59f, 1);
        Product product4 = new Product("Cheese", "4", 12.99f, 1);
        Product product5 = new Product("Book", "5", 9.99f, 2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        order2.DisplayShippingInfo();


    }
}


