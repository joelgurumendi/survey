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
    public class OptionConfiguration : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            var data = new List<Option> 
            { 
                new Option(Guid.Parse("f069ef5a-107c-4dc9-a629-1a0702976d8d"), Guid.Parse("8feb3112-f8f3-41b5-862b-bd35b899c96e"), "Pizza", 1, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("fdf913cb-ccb4-4f91-ac73-c0b78d8142da"), Guid.Parse("8feb3112-f8f3-41b5-862b-bd35b899c96e"), "Hamburguesa", 2, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("5d4059ac-b72a-4dd5-8b9f-0e287a450884"), Guid.Parse("8feb3112-f8f3-41b5-862b-bd35b899c96e"), "Sushi", 3, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("98a77a34-5ce4-487b-830c-8c78652a84dd"), Guid.Parse("8feb3112-f8f3-41b5-862b-bd35b899c96e"), "Ensalada", 4, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),

                new Option(Guid.Parse("91b15628-d3d2-444d-9eaf-a805dae426fe"), Guid.Parse("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), "Menos de una vez", 1, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("c4df8758-2fc8-4277-8a5d-e2b76a3319a0"), Guid.Parse("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), "De 1 a 3 veces", 2, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("59b840ad-869c-4517-be8d-21644e125c92"), Guid.Parse("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), "De 4 a 6 veces", 3, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("3926bb9c-4232-4d09-8f17-554c40be3fdd"), Guid.Parse("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), "Más de 6 veces", 4, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),

                new Option(Guid.Parse("b2cbbe07-d0b2-4e47-a815-a32d7c283189"), Guid.Parse("6cf7f688-b896-4c24-97ca-09eaca788680"), "Italiana", 1        , Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("0de3a2c2-6bc1-4377-9dac-6388ec8c2fd0"), Guid.Parse("6cf7f688-b896-4c24-97ca-09eaca788680"), "Mexicana", 2    , Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("d22f76ae-5d1d-42ac-85fd-cd5a2aa8e7d4"), Guid.Parse("6cf7f688-b896-4c24-97ca-09eaca788680"), "China", 3           , Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("49431509-9eb5-4488-ab78-74da672f8fa1"), Guid.Parse("6cf7f688-b896-4c24-97ca-09eaca788680"), "India", 4, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),

                new Option(Guid.Parse("309239c3-3919-4f61-9ad9-35791b5219fe"), Guid.Parse("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), "Menos de 1 porción", 1, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("28f46940-7f4a-4d6b-b7ea-afe23044acf5"), Guid.Parse("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), "De 1 a 2 porciones", 2, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("cb7afa45-856c-4658-a300-dc8c456e1dc9"), Guid.Parse("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), "De 3 a 4 porciones", 3, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("6a0e9386-3d0d-4608-90df-0d4573779bdf"), Guid.Parse("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), "Más de 4 porciones", 4, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),

                new Option(Guid.Parse("3afa3c45-2a45-4550-bf31-7483a9dc5dca"), Guid.Parse("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), "Pastel de chocolate", 1, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("c7f37b78-d8df-45a8-99f7-5bb5b5553625"), Guid.Parse("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), "Helado", 2, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("6d0efe10-06cd-4f63-816e-2879ac6c910e"), Guid.Parse("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), "Frutas frescas", 3, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c")),
                new Option(Guid.Parse("6daa26db-08b4-4067-a0c3-4a16ef7def49"), Guid.Parse("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), "Flan", 4, Guid.Parse("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"))
            };

            builder.ToTable(nameof(Option));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Label).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Order).IsRequired();

            builder.HasOne(d => d.Question).WithMany(p => p.Options).HasForeignKey(d => d.QuestionId);

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
