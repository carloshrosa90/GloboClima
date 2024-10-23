using GloboClima.Domain.Weather;
using GloboClima.Repository.ClassFirstCode;
using Microsoft.EntityFrameworkCore;
namespace GloboClima.Repository
{
    public class FavoriteContext : DbContext
    {
        public FavoriteContext(DbContextOptions<FavoriteContext> options) : base(options) { }

        public DbSet<Favorite> Favorite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;TrustServerCertificate=true;Persist Security Info=False;User ID=Carlos-Pc\\Carlos;Initial Catalog=GloboClima;Data Source=CARLOS-PC\\SQLEXPRESS");
        }
    }
}
