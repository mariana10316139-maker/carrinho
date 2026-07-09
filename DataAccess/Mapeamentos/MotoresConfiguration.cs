using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class MotoresConfiguration : IEntityTypeConfiguration<Motores>
{
    public void Configure(EntityTypeBuilder<Motores> builder)
    {
        builder.ToTable("Motores");

        builder.HasKey(x => x.IdMotor);

        builder.Property(x => x.IdMotor)
            .HasColumnName("IdMotor");

        builder.Property(x => x.NMotor)
            .HasColumnName("NMotor")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Estado)
            .HasColumnName("Estado")
            .IsRequired();

        builder.Property(x => x.Rotacao)
            .HasColumnName("Rotacao")
            .HasPrecision(10, 2)
            .IsRequired();
    }
}