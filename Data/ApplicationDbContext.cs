using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using appfutbol.Models;

namespace appfutbol.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Player> Players { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Assignment> Assignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Relación única: un jugador no puede estar dos veces en el mismo equipo
        modelBuilder.Entity<Assignment>()
            .HasIndex(a => new { a.PlayerId, a.TeamId })
            .IsUnique();

        // Relaciones de navegación
        modelBuilder.Entity<Assignment>()
            .HasOne(a => a.Player)
            .WithMany(p => p.Assignments)
            .HasForeignKey(a => a.PlayerId);

        modelBuilder.Entity<Assignment>()
            .HasOne(a => a.Team)
            .WithMany(t => t.Assignments)
            .HasForeignKey(a => a.TeamId);
    }
}
