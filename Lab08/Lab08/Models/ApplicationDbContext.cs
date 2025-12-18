using Microsoft.EntityFrameworkCore;

namespace Lab08.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        //public DbSet<Customer> Customers { get; set; } = null!;
        //public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<CarModel> CarModels { get; set; } = null!;
        //public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    }
}
