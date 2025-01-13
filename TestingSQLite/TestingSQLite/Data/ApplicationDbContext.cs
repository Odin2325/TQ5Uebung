using Microsoft.EntityFrameworkCore;
using TestingSQLite.Models;
using TestingSQLite.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Customize table and column mappings (optional)
        modelBuilder.Entity<Client>().HasKey(c => c.ID); // Primary Key
    }
}
