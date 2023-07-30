using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ConnectionDBContext : DbContext
    {
        public ConnectionDBContext(DbContextOptions<ConnectionDBContext> options) : base(options)
        {
        }
         public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}