using Microsoft.EntityFrameworkCore;
using Phinscal.Models;

namespace Phinscal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }

    }
}
