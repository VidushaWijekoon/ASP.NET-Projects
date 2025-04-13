using Microsoft.EntityFrameworkCore;
using HRMS.Models;

public class HrDbContext : DbContext
{
    public HrDbContext(DbContextOptions<HrDbContext> options)
        : base(options) { }

    public DbSet<Branch> Branches { get; set; }

    // Add other DbSet<T> here
}
