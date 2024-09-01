using System;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

    // Required properties
    public string UserId { get; set; }
    public User User { get; set; }

    // Default constructor
    public Product()
    {
        // Initialize properties with default values or use constructor parameters
        Id = Guid.NewGuid(); // or another default value if appropriate
        Name = string.Empty;
        Description = string.Empty;
        Price = 0.0m;
        Category = string.Empty;
        UserId = string.Empty;
        User = new User(); // Ensure User is initialized
    }

    // Parameterized constructor for initialization
    public Product(string name, string description, decimal price, string category, string userId, User user)
    {
        Id = Guid.NewGuid(); // or use an existing GUID if appropriate
        Name = name;
        Description = description;
        Price = price;
        Category = category;
        UserId = userId;
        User = user;
    }
}
