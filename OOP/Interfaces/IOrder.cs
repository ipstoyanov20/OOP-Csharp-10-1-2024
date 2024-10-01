namespace OnlineStore.Interfaces;
using OnlineStore.Implementations;

public interface IOrder
{
    bool CreateOrder(ICustomer customer, PhysicalProduct product, int quantity);
    void ApplyDiscount(IDiscount discount);
    void CompleteOrder();
}