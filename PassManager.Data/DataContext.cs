using Microsoft.EntityFrameworkCore;
using PassManager.Domain.Models;

namespace PassManager.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial " +
            "Catalog=PassManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> User { get; set; }
        public DbSet<StoredPassword> StoredPassword { get; set; }
        public DbSet<Options> Options { get; set; }
    }
}