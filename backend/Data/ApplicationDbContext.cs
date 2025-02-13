using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Profile>().HasData(
              new Profile { Id = 1, Name = "Admin", Status = true },
              new Profile { Id = 2, Name = "Vendedor", Status = true },
              new Profile { Id = 3, Name = "Gerente", Status = true }
          );
        }
    }
}
