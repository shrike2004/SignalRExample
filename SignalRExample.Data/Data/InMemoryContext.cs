using Microsoft.EntityFrameworkCore;

namespace SignalRExample.Data.Data
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext(DbContextOptions<InMemoryContext> options)
            : base(options)
        { }

        public DbSet<PresentorPivotRow> PresentorPivotRows { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
