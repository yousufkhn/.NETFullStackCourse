using Microsoft.EntityFrameworkCore;

namespace EFCoreMVCDemo.Models
{
    public class LPUTrialDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer("Server=.\\Sqlexpress;Integrated Security=SSPI;Database=LPUTrialDb;TrustServerCertificate=true");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
