using Microsoft.EntityFrameworkCore;
using Dominio;

namespace DataAccess;

public class Contexto : DbContext
{
    public DbSet<Motores> Motores {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=Dbcarrinho;User ID=Sa; Password=Senha@123;Encrypt=False;TrustServerCertificate=True;"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MotoresConfiguration());
    }
}
    
