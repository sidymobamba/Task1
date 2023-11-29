using Microsoft.EntityFrameworkCore;
using Task1.Entities;

namespace Task1.DbContexts
{
    public class DbInfo: DbContext
    {
        public DbInfo(DbContextOptions<DbInfo> options) : base(options)
        {
        }

        public DbSet<DbClass> DbClasses { get; set; }
    }
}
