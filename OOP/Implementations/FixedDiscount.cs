namespace OnlineStore.Implementations;
using OnlineStore.Interfaces;

public class FixedDiscount : IDiscount
{
    public FixedDiscount(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get; }

    public decimal CalculateDiscount(decimal total)
    {
        return Math.Min(Amount, total);
    }
}