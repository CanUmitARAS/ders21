using Ders21.Data.Entity;
using ders21.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ders21.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = "123456", Email = "admin@example.com" },
                new User { Id = 2, Username = "admin2", Password = "123456", Email = "admin2@example.com" },
                new User { Id = 3, Username = "admin3", Password = "123456", Email = "admin3@example.com" },
                new User { Id = 4, Username = "admin4", Password = "123456", Email = "admin4@example.com" }
            ); ;
        }
    }
}
