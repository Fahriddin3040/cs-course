using Microsoft.EntityFrameworkCore;
using Server.UserLayer;

namespace Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(e => 
            {
                e.HasKey(u => u.Id);

                e.HasIndex(u => u.Username).IsUnique();
            });
        }
    }
}