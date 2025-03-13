using System.Reflection.Emit;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(string name, string street, string city, string state, string country)
    {
        _customer = new Customer(name, street, city, state, country);
        _products = new List<Product>();
    }

    public void AddProduct(string name, int id, double price, int quantity)
    {
        Product prod = new Product(name, id, price, quantity);
        _products.Add(prod);
    }

    public double GetTotal()
    {
        double total = 0.0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        if(_customer.IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 15;
        }
        return Math.Round(total, 2);
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach(Product p in _products)
        {
            label += $"\nProduct: {p.GetName()} \nID: {p.GetID()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\nAddress: {_customer.GetAddress()}\n";
    }
}