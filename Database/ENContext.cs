using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ENContext : DbContext
    {
        public ENContext(DbContextOptions<ENContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Card> Card { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Cards)
                .WithOne(e => e.User)
                .HasForeignKey(c => c.UserId);
            
            modelBuilder.Entity<Card>();
        }
    }
}
