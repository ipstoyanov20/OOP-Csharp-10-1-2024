namespace OnlineStore.Implementations;
using OnlineStore.Interfaces;

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