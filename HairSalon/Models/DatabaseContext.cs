using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class DatabaseContext : DbContext
  {
    public DatabaseContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}