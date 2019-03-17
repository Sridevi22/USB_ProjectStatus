using Microsoft.EntityFrameworkCore;

namespace ProjectStatus.Models
{
    public class ProjectStatusDetailContext : DbContext
    {
        public ProjectStatusDetailContext(DbContextOptions<ProjectStatusDetailContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectStatusDetail> ProjectStatusDetail { get; set; }
    }
}