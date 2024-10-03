namespace Services.Implementations;
using Services.Interfaces;
public abstract class Order
{
    private PhysicalProductOrder physicalProductOrder = new PhysicalProductOrder();
    public Customer customer { get; set; }
    public Product product { get; set; }
    public int Quantity { get; set; }
    public decimal Discount { get; set; }

    public virtual bool CreateOrder()
    {
        if (product.ValidateStock(Quantity))
        {
            product.Stock -= Quantity;
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient stock.");
            return false;
        }
    }

    public virtual void ApplyDiscount(IDiscount discount)
    {
        Discount = discount.CalculateDiscount(physicalProductOrder._orderItems ,product.Price * Quantity);
    }

    public abstract void CompleteOrder();
}