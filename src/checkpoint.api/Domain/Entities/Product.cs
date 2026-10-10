using Checkpoint.Domain.ValueObjects;

namespace Checkpoint.Domain.Entities;

public class Product
{

    private Product(
        string id,
        Name name,
        decimal price,
        string brand,
        string category,
        Description description
    )
    {
        Id = id;
        Name = name;
        Price = price;
        Brand = brand;
        Category = category;
        Description = description;
    }

    public string Id { get; private set; }
    public Name Name { get; private set; }
    public decimal Price { get; private set; }
    public string Brand { get; private set; }
    public string Category { get; private set; }
    public Description Description { get; private set; }


    public static Product Create(
        string Id,
        Name Name,
        decimal Price,
        string Brand,
        string Category,
        Description Description
    )
    {
        return new Product(Id, Name, Price, Brand, Category, Description);
    }
}