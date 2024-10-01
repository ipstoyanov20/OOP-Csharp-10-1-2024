namespace OnlineStore.Implementations;
public class PhysicalProduct
{
    public PhysicalProduct(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; }
    public decimal Price { get; }
    public int Quantity { get; set; }

    public event EventHandler<string> OutOfStock;

    public void DecreaseQuantity(int amount)
    {
        Quantity -= amount;
        if (Quantity <= 0)
        {
            OutOfStock?.Invoke(this, $"[{Name}] is now out of stock!");
        }
    }
}