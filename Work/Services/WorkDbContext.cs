using Microsoft.EntityFrameworkCore;
using Work.Models;

namespace Work.Services;

public class WorkDbContext : DbContext
{
    public WorkDbContext(DbContextOptions<WorkDbContext> options) : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }
}