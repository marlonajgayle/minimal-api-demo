var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

app.MapGet("/products", () =>
{
    var products = new List<Product>
    {
        new Product { Id = 1, Name = "Cannon - M50 MK II", Description = "EOS M50 Mark II EF-M 15-45mm IS STM Kit Black", Price = 699.99m },
        new Product { Id = 2, Name = "Cannon - M3", Description = "EOS M3 EF-M 18-55mm IS STM Kit Black", Price = 549.99m },
        new Product { Id = 3, Name = "Cannon - EOS R100", Description = "EOS R100 EF-M 15-45mm IS STM Kit", Price = 1099.00m },
        new Product { Id = 4, Name = "Cannon - EOS R6 MK II", Description = "EOS R6 Mark II Body with Stop Motion Animation Firmware", Price = 1519.00m },
        new Product { Id = 5, Name = "Cannon - EOS R7", Description = "EOS R7 EF-M 15-45mm IS STM Kit", Price = 549.99m },
        new Product { Id = 6, Name = "Cannon - EOS R8", Description = "EOS R8 EF-M 15-45mm IS STM Kit", Price = 1299.00m },
        new Product { Id = 7, Name = "Cannon - EOS R6 Mark II", Description = "EOS R6 Mark II RF24-105mm F4 L IS USM Lens Kit", Price = 3399.00m },
        new Product { Id = 8, Name = "Cannon - EOS R5 C", Description = "EOS R5 C RF24-105mm F2.8 L IS USM Z Lens Kit", Price = 549.99m },
        new Product { Id = 9, Name = "Cannon - EOS R7", Description = "EOS R7 RF-S18-150mm F3.5-6.3 IS STM Lens Kit", Price = 1799.00m },
        new Product { Id = 10, Name = "Cannon - EOS R7 ", Description = "EOS R7 Content Creator Kit", Price = 1899.00m }
    };

    return products;
});

app.Run();

internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
}
