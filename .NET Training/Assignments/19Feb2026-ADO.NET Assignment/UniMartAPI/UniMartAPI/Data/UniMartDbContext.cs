using Microsoft.EntityFrameworkCore;
using UniMartAPI.Models;

namespace UniMartAPI.Data
{
    public class UniMartDbContext : DbContext
    {
        public UniMartDbContext(DbContextOptions<UniMartDbContext> options) : base(options) { }

        // DbSet -> means table
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // whenever we change anything over here, we should be creating a new migration
            // using -> dotnet ef migrations add [migrationname]
            // then -> dotnet ef database update


            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { CategoryId = 1, Name="Books"},
                    new Category { CategoryId = 2, Name = "Electronics" },
                    new Category { CategoryId = 3, Name = "Furniture" },
                    new Category { CategoryId = 4, Name = "Hostel Essentials" },
                    new Category { CategoryId = 5, Name = "Clothing" },
                    new Category { CategoryId = 6, Name = "Accessories"},
                    new Category { CategoryId = 7, Name = "Sports"},
                    new Category { CategoryId = 8, Name = "Others"}
                );
        }
    }
}
