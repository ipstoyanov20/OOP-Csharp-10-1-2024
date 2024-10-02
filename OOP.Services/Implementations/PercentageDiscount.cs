namespace Services.Implementations;
using Services.Interfaces;
public class PercentageDiscount : IDiscount
{
    public PercentageDiscount(int percentage)
    {
        Percentage = percentage;
    }

    public int Percentage { get; }

    public decimal CalculateDiscount(decimal total)
    {
        return total * (Percentage / 100.0m);
    }
}