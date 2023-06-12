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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            var data = new List<Question> 
            { 
                new Question(Guid.Parse("8feb3112-f8f3-41b5-862b-bd35b899c96e"), Guid.Parse("70a469f8-d412-4297-83b0-478e6407c298"), Guid.Parse("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), "¿Cuál es tu comida favorita?", 1, true, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Question(Guid.Parse("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), Guid.Parse("70a469f8-d412-4297-83b0-478e6407c298"), Guid.Parse("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), "¿Cuántas veces a la semana sueles comer comida rápida?", 2, true, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Question(Guid.Parse("6cf7f688-b896-4c24-97ca-09eaca788680"), Guid.Parse("70a469f8-d412-4297-83b0-478e6407c298"), Guid.Parse("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), "Si tuvieras que elegir solo un tipo de comida para comer durante un mes, ¿cuál sería?", 3, true, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Question(Guid.Parse("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), Guid.Parse("70a469f8-d412-4297-83b0-478e6407c298"), Guid.Parse("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), "¿Cuántas porciones de frutas y verduras consumes al día, en promedio?", 4, true, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Question(Guid.Parse("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), Guid.Parse("70a469f8-d412-4297-83b0-478e6407c298"), Guid.Parse("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), "¿Cuál es tu postre favorito?", 5, true, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Question(Guid.Parse("e5ecdf94-87f5-4b15-9a09-3f80e2d9ead2"), Guid.Parse("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"), Guid.Parse("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), "¿Cuántas horas a la semana dedicas a realizar ejercicio físico?", 6, true, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
            };

            builder.ToTable(nameof(Question));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Label).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Order).IsRequired();
            builder.Property(x => x.Required).IsRequired();

            builder.HasOne(x => x.AnswerType).WithMany(x => x.Questions).HasForeignKey(x => x.AnswerTypeId);
            builder.HasOne(x => x.Version).WithMany(x => x.Questions).HasForeignKey(x => x.VersionId);

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
