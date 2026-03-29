public class Product
{
    private string _name;
    private int _productId;
    private int _pricePer;
    private int _quantity;

    public Product(string name, int productId, int pricePer, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePer = pricePer;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _productId;
    }

    public int TotalCost()
    {
        return _pricePer * _quantity;
    }
}