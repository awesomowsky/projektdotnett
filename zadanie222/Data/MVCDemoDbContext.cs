using Microsoft.EntityFrameworkCore;
using zadanie222.Models.Domain;

namespace zadanie222.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
