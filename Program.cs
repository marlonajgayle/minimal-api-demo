var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/products", () =>
{
    var products = new List<Product>
    {
        new Product { Id = 1, Name = "Cannon - M50 MK II", Description = "EOS M50 Mark II EF-M 15-45mm IS STM Kit Black", Price = 699.99m },
        new Product { Id = 2, Name = "Cannon - M3", Description = "EOS M3 EF-M 18-55mm IS STM Kit Black", Price = 549.99m },
        new Product{Id= 3, Name = "Cannon - EOS M200", Description = "EOS M200 EF-M 15-45mm IS STM Kit", Price = 549.99m}
    };

    return products;
});

app.Run();

internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
}