using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class PanhaConfiguration : IEntityTypeConfiguration<Panha>
{
    public void Configure(EntityTypeBuilder<Panha> builder)
    {
        builder.ToTable("Panhas").HasKey(panha => panha.IdPanha);

        builder.Property(panha => panha.IdPanha).HasColumnName("IdPanha");

        builder.Property(panha => panha.NomeColobarador).HasColumnName("NomeColobarador");

        builder.Property(panha => panha.Nmedidas).HasColumnName("Nmedidas");

        builder.Property(panha => panha.Nlitros).HasColumnName("Nlitros");

        builder.Property(panha => panha.Data).HasColumnName("Data");
    }
}
