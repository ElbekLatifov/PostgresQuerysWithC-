using Microsoft.EntityFrameworkCore;
using PostgresQuerysWithC_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgresQuerysWithC_.Context;

public class AppDbContext : DbContext
{
    public DbSet<Humans> humans => Set<Humans>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;");
    }


}
