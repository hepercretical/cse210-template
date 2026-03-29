public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int CalculateCost()
    {
        int cost = 0;

        foreach (Product p in _products)
        {
            cost += p.TotalCost();
        }

        if (_customer.InUSA() == true)
        {
            cost += 5;
        }
        else if (_customer.InUSA() == false)
        {
            cost += 35;
        }
        return cost;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetName()} - Product ID {p.GetId()}");
        }
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} - {_customer.GetAddress()}";
    }
}