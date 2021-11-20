using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Community> Communities { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}