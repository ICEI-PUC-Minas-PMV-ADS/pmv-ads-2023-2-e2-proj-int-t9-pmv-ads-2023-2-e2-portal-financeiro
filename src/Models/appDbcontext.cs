using Microsoft.EntityFrameworkCore;

namespace PORTAL2023.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Despesa> Despesas { get; set; }

        public DbSet<Divida> Dividas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }




    }
}
