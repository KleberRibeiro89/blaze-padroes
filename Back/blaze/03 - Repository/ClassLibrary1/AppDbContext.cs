using Microsoft.EntityFrameworkCore;

namespace Blaze.Repository;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Aposta> Apostas { get; set; }
}
