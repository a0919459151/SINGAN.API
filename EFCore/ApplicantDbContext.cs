using Microsoft.EntityFrameworkCore;

namespace SINGAN.API.EFCore;

public class ApplicantDbContext : DbContext
{
    public DbSet<Applicant>? Applicants { get; set; }

    public ApplicantDbContext(DbContextOptions<ApplicantDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
