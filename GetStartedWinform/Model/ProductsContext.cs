using Microsoft.EntityFrameworkCore;


namespace GetStartedWinform.Model
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=DESKTOP-3TDDG7N;Database=testDB;ConnectRetryCount=0;Integrated Security=True;TrustServerCertificate=True");



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "aaa" },
                new Category { CategoryId = 2, Name = "bbb" }

                );

            
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "a1" },
                new Product { ProductId = 2, CategoryId = 1, Name = "a2" },
                new Product { ProductId = 3, CategoryId = 2, Name = "b1" },
                new Product { ProductId = 4, CategoryId = 2, Name = "b2" }


                );



        }
    }
}
