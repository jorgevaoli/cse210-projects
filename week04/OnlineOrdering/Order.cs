public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = _products.Sum(p => p.GetTotalCost());
        totalCost += _customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", _products.Select(p => p.GetPackingLabel()));
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}
