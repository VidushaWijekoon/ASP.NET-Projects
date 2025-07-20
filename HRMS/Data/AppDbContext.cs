using Microsoft.EntityFrameworkCore;
using HRMS.Models;

namespace HRMS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Branch>(entity =>
            {

                entity.ToTable("Branches")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci")
                    .HasAnnotation("MySql:Engine", "InnoDB");

                entity.HasKey(b => b.BranchId);

                entity.Property(b => b.BranchId)
                      .ValueGeneratedOnAdd();

                entity.Property(b => b.BranchStatus)
                      .HasConversion<string>();
            });
        }
    }
}
