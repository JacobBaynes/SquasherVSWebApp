using SquasherVSWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SquasherVSWebApp.Data
{
    public class SquasherContext : DbContext
    {
        public SquasherContext(DbContextOptions<SquasherContext> options) : base(options)
        {
        }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Squasher> Squashers { get; set; }
        public DbSet<ProjectBugAssignment> ProjectBugAssignments { get; set; }
        public DbSet<ProjectSquasherAssignment> ProjectSquasherAssignments { get; set; }
        public DbSet<SquasherBugAssignment> SquasherBugAssignments { get; set; }

    }
}
