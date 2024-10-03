namespace Services.Implementations;
using Services.Interfaces;
using Data.Models;

public class PhysicalProductOrder : IOrder
{
    public List<OrderItem> _orderItems = new List<OrderItem>();

    public bool CreateOrder(ICustomer customer, PhysicalProduct product, int quantity)
    {
        // Validate order creation (e.g., check product availability)
        if (product.Quantity >= quantity)
        {
            // Create the order item
            OrderItem orderItem = new OrderItem(product, quantity);
            _orderItems.Add(orderItem);

            // Decrease product quantity
            product.DecreaseQuantity(quantity);

            return true;
        }

        return false;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (OrderItem item in _orderItems)
        {
            totalPrice += item.Product.Price * item.Quantity;
        }
        return totalPrice;
    }

    public void ApplyDiscount(IDiscount discount)
    {
        // Apply the discount to the order
        decimal discountAmount = discount.CalculateDiscount(_orderItems, 1);
        foreach (OrderItem item in _orderItems)
        {
            item.Price -= discountAmount / _orderItems.Count;
        }
    }

    public void CompleteOrder()
    {
        // Complete the order (e.g., update order status)
        // ...
        Console.WriteLine("Order completed successfully!");
    }
}