namespace Soccer.Web.Data.Entities
{
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<TeamEntity> Teams { get; set; }

    }
}
