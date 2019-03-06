using Microsoft.EntityFrameworkCore;
using IEX.Models;

namespace IEX.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Equity> Equities { get; set; }
    }
}
