using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AppUser>().HasData(
            new AppUser { Id = 1, UserName = "Laith" },
            new AppUser { Id = 2, UserName = "Leen"  },
            new AppUser { Id = 3, UserName = "Yousef" },
            new AppUser { Id = 4, UserName =  "Jamal"},
            new AppUser { Id = 5, UserName =  "Ghadeer"}
        );
    }
}
