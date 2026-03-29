using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Creation of address, customer, and order for Jake.
        Address jakeAddress = new Address("362 Oak Lane", "St. Paul", "Arkansas", "USA");
        Customer jake = new Customer("Jake", jakeAddress);
        Order jakeOrder = new Order(jake);
        jakeOrder.AddProduct(new Product("Water Cups", 4451987, 2, 18000));
        jakeOrder.AddProduct(new Product("Taco Seasoning", 319163285, 4, 2));

        // Creation of address, customerand order for Sully.
        Address sullyAddress = new Address("7866 Park Road", "Southampton", "Hampshire", "UK");
        Customer sully = new Customer("Sully", sullyAddress);
        Order sullyOrder = new Order(sully);
        sullyOrder.AddProduct(new Product("Loaf of Bread", 000000001, 3, 4));
        sullyOrder.AddProduct(new Product("Garlic Salt", 346758, 2, 1));
        sullyOrder.AddProduct(new Product("Unsalted Butter", 1290567234, 6, 4));
        
        Console.WriteLine("=======================================================");

        Console.WriteLine("Packing Label:");
        jakeOrder.DisplayPackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(jakeOrder.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Cost: ${jakeOrder.CalculateCost()}");

        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        sullyOrder.DisplayPackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(sullyOrder.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Cost: ${sullyOrder.CalculateCost()}");
    }
}