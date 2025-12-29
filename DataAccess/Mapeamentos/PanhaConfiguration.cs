public class PanhaConfiguration : IEntityTypeConfiguration<Panha>
{
    public void Configure(EntityTypeBuilder<Panha> Builder)
    {
        build.ToTable("Panha").HasKey(panha => panha.IdPanha);
        build.Property(panha => panha.IdPanha).HasColumnName("IdPanha");
        build.Property(panha => panha.NomeColobarador).HasColumnName("NomeColobarador");
        build.Property(panha => panha.Nmedidas).HasColumnName("Nmedidas");
        build.Property(panha => panha.Nlitros).HasColumnName("Nlitros");

    }
}