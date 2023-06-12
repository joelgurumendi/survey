using Surveys.Domain.Surveys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Infrastructure.Data.Configurations
{
    public class VersionConfiguration : IEntityTypeConfiguration<Version>
    {
        public void Configure(EntityTypeBuilder<Version> builder)
        {
            var data = new List<Version> { new Version(Guid.Parse("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), "Default", Guid.Parse("de22342c-777b-4037-ba79-a31ac7c4e6fd"), DateTime.UtcNow, DateTime.UtcNow.AddDays(5), Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")) };

            builder.ToTable(nameof(Version));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.From).IsRequired();
            builder.Property(x => x.To).IsRequired();

            builder.HasOne(x => x.Survey).WithMany(x => x.Versions).HasForeignKey(x => x.SurveyId);

            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired(false);
            builder.Property(x => x.DeletedAt).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired();

            builder.HasData(data);
        }
    }
}
