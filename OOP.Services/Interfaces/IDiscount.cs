namespace Services.Interfaces;
using Services.Implementations;

public interface IDiscount
{
    decimal CalculateDiscount(List<OrderItem> orderItems, decimal discountPercentage);
}