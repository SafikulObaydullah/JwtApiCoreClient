using DemoJWTSwaggerData.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoJWTSwaggerData.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public virtual DbSet<User> User { get; set; }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         // base.OnModelCreating(modelBuilder);
         modelBuilder.Entity<Product>()
                     .HasData(
                     new Product
                     {
                        Id = 1,
                        ProductCode = "P001",
                        ProductName = "Water Bottle",
                        UnitPrice = 500
                     },
                      new Product
                      {
                         Id = 2,
                         ProductCode = "P002",
                         ProductName = "Hot Water Pot",
                         UnitPrice = 1000
                      },
                       new Product
                       {
                          Id = 3,
                          ProductCode = "P003",
                          ProductName = "Mum Pot",
                          UnitPrice = 500
                       }
                     );
      }
      public DbSet<Product> Products { get; set; }
      public DbSet<SalesMaster> SalesMasters { get; set; }
      public DbSet<SalesDetail> SalesDetails { get; set; }
   }
}
