
using MyWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Client { get; set; }
    }
}
