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
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable(nameof(Answer));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Value).IsRequired(false);
            
            builder.HasOne(x => x.Question).WithMany(x => x.Answers).HasForeignKey(x => x.QuestionId);
            builder.HasOne(x => x.Version).WithMany(x => x.Answers).HasForeignKey(x => x.VersionId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.Option).WithMany(x => x.Answers).HasForeignKey(x => x.OptionId).IsRequired(false);
            builder.HasOne(x => x.Survey).WithMany(x => x.Answers).HasForeignKey(x => x.SurveyId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired(false);
            builder.Property(x => x.DeletedAt).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired();
        }
    }
}
