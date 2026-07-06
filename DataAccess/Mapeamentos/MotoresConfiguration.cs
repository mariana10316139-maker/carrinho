using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class MotoresConfiguration : IEntityTypeConfiguration<Motores>
{
    public void Configure(EntityTypeBuilder<Motores> builder)
    {
        builder.ToTable("Motores").HasKey(motores => motores.IdMotores);

        builder.Property(motores => motores.IdMotores).HasColumnName("IdMotores");

        builder.Property(motores => motores.NomeMotores).HasColumnName("NomeMotores");

        builder.Property(motores => motores.Estado).HasColumnName("Estado");

        builder.Property(motores => motores.Rotacao).HasColumnName("Rotacao");

        builder.Property(motores => motores.Data).HasColumnName("Data");
    }
}
