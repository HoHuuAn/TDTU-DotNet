using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;


namespace Exercise1
{
    public class MarketingContext : DbContext
    {
        String connectionString = "Data Source=An\\SQLEXPRESS;Initial Catalog=OnlineMarketing;Integrated Security=True;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);

        }


        public DbSet<Phone> Phones { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }
    }
}
