using be_poc.Models;
using Microsoft.EntityFrameworkCore;

namespace be_poc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Order> Order { get; set; }
    }
}