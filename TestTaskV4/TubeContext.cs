using Microsoft.EntityFrameworkCore;
using TestTaskV4.Models;

namespace TestTaskV4;

public class TubeContext : DbContext
{
    public TubeContext(DbContextOptions<TubeContext> options) : base(options)
    {
    }

    public DbSet<Pack> Pack { get; set; }

    public DbSet<SteelGrade> Bike { get; set; }

    public DbSet<Tube> Tube { get; set; }
}
