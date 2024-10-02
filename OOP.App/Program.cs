using Services.Implementations;
using Services.Interfaces;

namespace OOP;
public class Program
{
    public static void Main()
    {
        // Create a customer
        ICustomer customer = new Customer("John", "Doe");

        // Create products
        PhysicalProduct laptop = new PhysicalProduct("Laptop", 1000.00m, 5);
        PhysicalProduct smartphone = new PhysicalProduct("Smartphone", 700.00m, 2);

        // Subscribe to the out-of-stock event
        laptop.OutOfStock += (sender, message) => Console.WriteLine($"[EVENT] {message}");
        smartphone.OutOfStock += (sender,message) => Console.WriteLine($"[EVENT] {message}");

        // Create orders
        IOrder laptopOrder = new PhysicalProductOrder();
        IOrder smartphoneOrder = new PhysicalProductOrder();

        // Place orders with validation and discounts
        if (laptopOrder.CreateOrder(customer, laptop, 3))
        {
            // Apply a 10% discount to the laptop order
            laptopOrder.ApplyDiscount(new PercentageDiscount(10));

            laptopOrder.CompleteOrder();
        }

        Console.WriteLine();

        // Second order for smartphones
        if (smartphoneOrder.CreateOrder(customer, smartphone, 2))
        {
            // Apply a 550 fixed discount on smartphones
            smartphoneOrder.ApplyDiscount(new FixedDiscount(50));

            smartphoneOrder.CompleteOrder();
        }

        // Attempt to create an order with insufficient stock
        if (!laptopOrder.CreateOrder(customer, laptop, 3))
        {
            Console.WriteLine("Failed to create second Laptop order due to insufficient stock.");
        }
    }
}