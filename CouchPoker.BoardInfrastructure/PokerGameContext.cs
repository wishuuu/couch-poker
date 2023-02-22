using System.Reflection.Emit;
using CouchPoker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CouchPoker.Infrastructure;

public class PokerGameContext : DbContext
{
    public PokerGameContext(DbContextOptions<PokerGameContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<GameBoard>()
            .HasIndex(gb => gb.Id);
        modelBuilder.Entity<GameBoard>()
            .Property(gb => gb.Id).ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Player>()
            .HasIndex(gb => gb.Id);
        modelBuilder.Entity<Player>()
            .Property(gb => gb.Id).ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Card>()
            .HasIndex(gb => gb.Id);
        modelBuilder.Entity<Card>()
            .Property(gb => gb.Id).ValueGeneratedOnAdd();
        
        modelBuilder.Entity<PlayerState>()
            .HasIndex(gb => gb.Id);
        modelBuilder.Entity<PlayerState>()
            .Property(gb => gb.Id).ValueGeneratedOnAdd();

        modelBuilder.Entity<PlayerState>()
            .HasOne(ps => ps.Player)
            .WithOne(ps => ps.PlayerState);
        
        modelBuilder.Entity<GameBoard>()
            .HasMany(gb => gb.Players)
            .WithOne(ps => ps.GameBoard);
        
        modelBuilder.Entity<GameBoard>()
            .HasMany(gb => gb.Cards)
            .WithOne();
    }
}