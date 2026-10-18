using Microsoft.EntityFrameworkCore;
using JoelPertuzPortfolio.Models;

namespace JoelPertuzPortfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Certification> Certifications { get; set; } = null!;
    }
}