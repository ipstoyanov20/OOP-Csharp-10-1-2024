namespace Services.Implementations;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Stock: {Stock}");
    }

    public virtual bool ValidateStock(int quantity)
    {
        return quantity <= Stock;
    }
}