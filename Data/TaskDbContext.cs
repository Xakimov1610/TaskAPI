using Microsoft.EntityFrameworkCore;

namespace Task.Data
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Entities.Task> Tasks { get; set; }

        public TaskDbContext(DbContextOptions options)
            :base(options) { }
    }
}