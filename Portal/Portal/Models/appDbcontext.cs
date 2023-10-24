using Microsoft.EntityFrameworkCore;

namespace PORTAL.Models
{
    public class AppDbcontext : DbContext

    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) { }

        public DbSet<Despesa> Despesas { get; set; }

    }
}