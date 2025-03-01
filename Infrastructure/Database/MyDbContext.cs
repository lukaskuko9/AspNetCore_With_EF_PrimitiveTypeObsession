using Microsoft.EntityFrameworkCore;
using PrimitiveTypeObsession.Infrastructure.Entities;

namespace PrimitiveTypeObsession.Infrastructure.Database;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<MyDbEntity> MyDbEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}