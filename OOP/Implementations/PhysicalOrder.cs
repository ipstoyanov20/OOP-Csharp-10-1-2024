namespace OnlineStore.Implementations;
using OnlineStore.Interfaces;

public class PhysicalProductOrder : IOrder
{
    public bool CreateOrder(ICustomer customer, PhysicalProduct product, int quantity)
    {
        // Validate order creation (e.g., check product availability)
        if (product.Quantity >= quantity)
        {
            // Create the order
            // ...
            product.DecreaseQuantity(quantity);
            return true;
        }
        return false;
    }

    public void ApplyDiscount(IDiscount discount)
    {
        // Apply the discount to the order
        // ...
    }

    public void CompleteOrder()
    {
        // Complete the order (e.g., update order status)
        // ...
    }
}