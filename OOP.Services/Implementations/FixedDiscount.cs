namespace Services.Implementations;
using Services.Interfaces;

public class FixedDiscount : IDiscount
{
    public FixedDiscount(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get; }

    public decimal CalculateDiscount(List<OrderItem> orderItems, decimal discountPercentage)
    {
        decimal totalPrice = 0;
        foreach (OrderItem item in orderItems)
        {
            totalPrice += item.Product.Price * item.Quantity;
        }

        decimal discountAmount = totalPrice * discountPercentage / 100;
        return discountAmount;
    }
}