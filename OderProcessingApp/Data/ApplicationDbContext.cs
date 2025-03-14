using Microsoft.EntityFrameworkCore;
using OderProcessingApp.Models;

namespace OderProcessingApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }

        public DbSet<Order> orders { get; set; }

    }
}
