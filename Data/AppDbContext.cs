using Microsoft.EntityFrameworkCore;
using wt_lab7_7postgres_alasevic.Models;

namespace wt_lab7_7postgres_alasevic.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Ноутбук Lenovo", Category = "Компьютеры", Price = 74999, IsAvailable = true, CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
            new Product { Id = 2, Name = "Мышь Logitech", Category = "Аксессуары", Price = 9990, IsAvailable = true, CreatedAt = new DateTime(2026, 1, 2, 0, 0, 0, DateTimeKind.Utc) },
            new Product { Id = 3, Name = "Клавиатура Keychron", Category = "Аксессуары", Price = 12990, IsAvailable = true, CreatedAt = new DateTime(2026, 1, 3, 0, 0, 0, DateTimeKind.Utc) }
        );
    }
}