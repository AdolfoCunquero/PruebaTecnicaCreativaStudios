using System.Data.Entity;

/// <summary>
/// Summary description for AppDbContext
/// </summary>
public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<WebTracker> WebTrackers { get; set; }

    public AppDbContext() : base("name=AppDbContext") { }
}