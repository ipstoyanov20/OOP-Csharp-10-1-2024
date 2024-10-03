namespace Services.Implementations;
using Services.Interfaces;

public class OrderItem
{
    public PhysicalProduct Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public OrderItem(PhysicalProduct product, int quantity)
    {
        Product = product;
        Quantity = quantity;
        Price = product.Price;
    }
}