using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TenisApp.Canchas.Domain.Entities;

namespace TenisApp.Canchas.Persistence.EntityTypeConfigurations;

public class CanchaEntityTypeConfiguration : IEntityTypeConfiguration<Cancha>
{
    public void Configure(EntityTypeBuilder<Cancha> builder)
    {
        // Primary key.
        builder.HasKey(cancha => cancha.CorrelationId);
        
        // CorrelationId.
        builder.Property(cancha => cancha.CorrelationId);
        
        // Code.
        builder.Property(cancha => cancha.CorrelationId);
        
        // Habilitada.
        builder.Property(cancha => cancha.Habilitada);
    }
}