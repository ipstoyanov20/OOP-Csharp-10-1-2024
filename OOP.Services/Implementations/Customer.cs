namespace Services.Implementations;

using Services.Interfaces;

public class Customer : ICustomer
{
    public Customer(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public string Name { get; }
    public string Surname { get; }
}