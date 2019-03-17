using Microsoft.EntityFrameworkCore;

namespace ProjectStatus.Models
{
    public class ProjectDetailContext : DbContext
    {
        public ProjectDetailContext(DbContextOptions<ProjectDetailContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectDetail> ProjectDetails { get; set; }
    }
}