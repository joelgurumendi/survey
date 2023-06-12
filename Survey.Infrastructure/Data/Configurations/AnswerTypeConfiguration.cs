using Surveys.Domain.Surveys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Infrastructure.Data.Configurations
{
    public class AnswerTypeConfiguration : IEntityTypeConfiguration<AnswerType>
    {
        public void Configure(EntityTypeBuilder<AnswerType> builder)
        {
            var data = new List<AnswerType> { new AnswerType(Guid.Parse("70a469f8-d412-4297-83b0-478e6407c298"), "Option", Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")), new AnswerType(Guid.Parse("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"), "Open", Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")) };

            builder.ToTable(nameof(AnswerType));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(20).IsRequired();

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
