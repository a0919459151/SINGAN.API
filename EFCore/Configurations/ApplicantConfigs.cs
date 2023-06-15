using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SINGAN.API.EFCore.Configurations;

public class ApplicantConfigs : IEntityTypeConfiguration<Applicant>
{
    public void Configure(EntityTypeBuilder<Applicant> builder)
    {
        // own value object
        // DriverLicence, Contact, EducationBackground, Thesis, WorkExperience, DatePeriod
        builder.Property(a => a.DriverLicenses)
            .HasConversion(
                licenses => string.Join(",", licenses!),
                licensesString => licensesString.Split(",", StringSplitOptions.RemoveEmptyEntries));

        builder.OwnsOne(x => x.EmergencyContact);

        builder.OwnsMany(x => x.EducationBackgrounds, x =>
        {
            x.OwnsOne(x => x.StartPeriod);
            x.OwnsOne(x => x.EndPeriod);
        });

        builder.OwnsOne(x => x.Thesis);

        builder.OwnsMany(x => x.WorkExperiences, x =>
        {
            x.OwnsOne(x => x.StartPeriod);
            x.OwnsOne(x => x.EndPeriod);
        });
    }
}
