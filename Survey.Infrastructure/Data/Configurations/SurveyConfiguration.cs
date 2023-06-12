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
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            var data = new List<Survey> { new Survey(Guid.Parse("de22342c-777b-4037-ba79-a31ac7c4e6fd"), "Preferencias de comida", "Esta encuesta tiene como objetivo recopilar las preferencias de comida de los usuarios. Los participantes deberán responder una serie de preguntas relacionadas con diferentes tipos de alimentos y realizar algunos cálculos matemáticos simples.", Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")) };

            builder.ToTable(nameof(Survey));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).IsRequired();

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
