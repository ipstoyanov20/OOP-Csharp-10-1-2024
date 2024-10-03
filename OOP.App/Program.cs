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
        smartphone.OutOfStock += (sender, message) => Console.WriteLine($"[EVENT] {message}");

        // Create orders
        IOrder laptopOrder = new PhysicalProductOrder();
        IOrder smartphoneOrder = new PhysicalProductOrder();

        // Place orders with validation and discounts
        if (laptopOrder.CreateOrder(customer, laptop, 2))
        {
            // Apply a 10% discount to the laptop order
            laptopOrder.ApplyDiscount(new PercentageDiscount(10));

            laptopOrder.CompleteOrder();
            Console.WriteLine("Order created for 2 unit(s) of Laptop.");
            Console.WriteLine("Discount applied. Final price: $" + laptopOrder.GetTotalPrice());
            Console.WriteLine("2 units of Laptop deducted from stock.");
            Console.WriteLine("Order completed for John Doe. Product shipped.");
        }

        Console.WriteLine();

        // Second order for smartphones
        if (smartphoneOrder.CreateOrder(customer, smartphone, 1))
        {
            // Apply a 550 fixed discount on smartphones
            smartphoneOrder.ApplyDiscount(new FixedDiscount(50));

            smartphoneOrder.CompleteOrder();
            Console.WriteLine("Order created for 1 unit(s) of E-Book.");
            Console.WriteLine("Discount applied. Final price: $" + smartphoneOrder.GetTotalPrice());
            Console.WriteLine("Order completed for John Doe. Download link sent.");
        }

        // Attempt to create an order with insufficient stock
        if (!laptopOrder.CreateOrder(customer, laptop, 3))
        {
            Console.WriteLine("Insufficient stock for Laptop. Available: 2");
            Console.WriteLine("Failed to create second laptop order due to insufficient stock.");
        }
    }
}