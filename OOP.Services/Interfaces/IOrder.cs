namespace Services.Interfaces;
using Services.Implementations;

public interface IOrder
{
    bool CreateOrder(ICustomer customer, PhysicalProduct product, int quantity);
    void ApplyDiscount(IDiscount discount);
    void CompleteOrder();

    decimal GetTotalPrice();
}