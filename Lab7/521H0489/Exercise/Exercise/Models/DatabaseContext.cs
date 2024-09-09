using Microsoft.EntityFrameworkCore;

namespace Exercise.Models
{
    public class DatabaseContext : DbContext
    {   
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
