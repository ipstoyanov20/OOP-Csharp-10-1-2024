namespace Services.Implementations;
using Services.Interfaces;

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