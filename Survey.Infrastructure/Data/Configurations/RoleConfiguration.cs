using Surveys.Domain.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Infrastructure.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            var data = new List<Role> { new Role("Interviewer", true, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")), new Role("Participant", false, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")) };

            builder.ToTable(nameof(Role));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(30).IsRequired();
            builder.Property(x => x.IsAdmin).IsRequired();

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
