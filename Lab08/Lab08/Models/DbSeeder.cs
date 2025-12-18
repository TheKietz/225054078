namespace Lab08.Models
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Brands.Any())
            {
                var toyota = new Brand { Name = "Toyota", Country = "Japan" };
                var hyundai = new Brand { Name = "hyundai", Country = "Korea" };

                context.Brands.AddRange(toyota, hyundai);
                context.SaveChanges();
                context.Cars.AddRange(
                    new Car { Name = "Vios", BrandId = toyota.BrandId },
                    new Car { Name = "Camry", BrandId = toyota.BrandId },
                    new Car { Name = "Accent", BrandId = hyundai.BrandId }
                );
                context.SaveChanges();
            }
        }
    }
}
