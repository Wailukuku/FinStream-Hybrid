using FinStream_Hybrid.Models;
using Microsoft.EntityFrameworkCore;

namespace FinStream_Hybrid.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions => Set<Transaction>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Pour la monnaie, on précise toujours la précision (18 chiffres, 2 après la virgule)
            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .HasPrecision(18, 2);
        }
    }
}
