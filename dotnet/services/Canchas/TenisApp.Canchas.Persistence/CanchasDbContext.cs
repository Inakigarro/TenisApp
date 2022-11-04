using Microsoft.EntityFrameworkCore;
using TenisApp.Canchas.Domain.Entities;
using TenisApp.Canchas.Persistence.EntityTypeConfigurations;

namespace TenisApp.Canchas.Persistence;

public class CanchasDbContext : DbContext
{
    public DbSet<Cancha> Canchas { get; set; }
    
    public CanchasDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new CanchaEntityTypeConfiguration()).HasDefaultSchema("Canchas");
    }
}