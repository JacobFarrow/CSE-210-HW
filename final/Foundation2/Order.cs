class Order
{
    List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        
        if (_customer.LiveInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += product.GetName() + " - " + product.GetProductId() + "\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\n";

        shippingLabel += _customer.GetName() + "\n";
        shippingLabel += _customer.GetAddressText() + "\n";

        return shippingLabel;
    }
}