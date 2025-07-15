using Microsoft.EntityFrameworkCore;
using PrimitiveTypeObsession.Infrastructure.Database.Extensions;
using PrimitiveTypeObsession.Infrastructure.Entities;

namespace PrimitiveTypeObsession.Infrastructure.Database;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(x =>
        {
            x.Property(user => user.FirstName).HasMaxLength(100);
            x.Property(user => user.LastName).HasMaxLength(100);
            
            x.Property(user => user.UserToken).AddUserTokenConversion();
            x.Property(user => user.NullableUserToken).AddUserTokenConversion();
            
            x.HasIndex(user=>user.UserToken).IsUnique();
            x.HasIndex(user=>user.NullableUserToken).IsUnique();
        });
        
        base.OnModelCreating(modelBuilder);
    }
}