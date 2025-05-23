using Microsoft.EntityFrameworkCore;
using Northwind.Demo.Entity.ModelConfigs;
using Northwind.Demo.Entity.Models;

namespace Northwind.Demo.Repository.Database;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

    public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

    public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    public virtual DbSet<UsState> UsStates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerCustomerDemoConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerDemographicConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeTerritoryConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderDetailConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RegionConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShipperConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SupplierConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TerritoryConfig).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsStateConfig).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
