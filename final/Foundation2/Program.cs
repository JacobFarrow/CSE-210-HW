using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Way", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        
        Product p1 = new Product("Laptop", "A100", 1000m, 1);
        Product p2 = new Product("Mouse", "B200", 25m, 2);
        Product p3 = new Product("Keyboard", "C300", 50m, 1);
        Product p4 = new Product("Monitor", "D400", 200m, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Order order2 = new Order(customer2);
        order2.AddProduct(p2);
        order2.AddProduct(p3);
        order2.AddProduct(p4); 

        Console.WriteLine("----------------ORDER 1----------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\n----------------ORDER 2----------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}