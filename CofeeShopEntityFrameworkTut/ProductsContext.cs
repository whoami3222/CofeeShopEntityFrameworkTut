
using Microsoft.EntityFrameworkCore;

namespace CofeeShopEntityFrameworkTut;

public class ProductsContext : DbContext
{
    internal DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source = products.db");
}
