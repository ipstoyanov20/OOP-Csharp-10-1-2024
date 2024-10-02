namespace Services.Implementations;
public class DigitalOrder : Order
{
    public override void CompleteOrder()
    {
        DigitalProduct physicalProduct = new DigitalProduct();
        Console.WriteLine($"Processing payment for {physicalProduct.Name}");
        // Implement payment processing logic
        physicalProduct.ProvideDownloadLink();
    }
}