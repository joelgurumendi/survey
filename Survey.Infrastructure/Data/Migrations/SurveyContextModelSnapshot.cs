﻿// <auto-generated />
using System;
using Surveys.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Surveys.Infrastructure.Data.Migrations
{
    [DbContext(typeof(SurveyContext))]
    partial class SurveyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Sur")
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Surveys.Domain.Session.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Role", "Sur");

                    b.HasData(
                        new
                        {
                            Id = new Guid("09becc02-53dd-4b58-8775-381c005204fb"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 32, DateTimeKind.Utc).AddTicks(4682),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsAdmin = true,
                            IsDeleted = false,
                            Name = "Interviewer"
                        },
                        new
                        {
                            Id = new Guid("db5c2f2d-9d4e-4852-9ff2-50ca32db738d"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 32, DateTimeKind.Utc).AddTicks(4795),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsAdmin = false,
                            IsDeleted = false,
                            Name = "Participant"
                        });
                });

            modelBuilder.Entity("Surveys.Domain.Session.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User", "Sur");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(2589),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            Email = "ljgurumendi@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Joel Gurumendi"
                        });
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("OptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("SurveyId");

                    b.HasIndex("VersionId");

                    b.ToTable("Answer", "Sur");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.AnswerType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AnswerType", "Sur");

                    b.HasData(
                        new
                        {
                            Id = new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(3333),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Option"
                        },
                        new
                        {
                            Id = new Guid("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(3338),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Open"
                        });
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Option", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Option", "Sur");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f069ef5a-107c-4dc9-a629-1a0702976d8d"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4403),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Pizza",
                            Order = 1,
                            QuestionId = new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e")
                        },
                        new
                        {
                            Id = new Guid("fdf913cb-ccb4-4f91-ac73-c0b78d8142da"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4489),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Hamburguesa",
                            Order = 2,
                            QuestionId = new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e")
                        },
                        new
                        {
                            Id = new Guid("5d4059ac-b72a-4dd5-8b9f-0e287a450884"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4491),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Sushi",
                            Order = 3,
                            QuestionId = new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e")
                        },
                        new
                        {
                            Id = new Guid("98a77a34-5ce4-487b-830c-8c78652a84dd"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4494),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Ensalada",
                            Order = 4,
                            QuestionId = new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e")
                        },
                        new
                        {
                            Id = new Guid("91b15628-d3d2-444d-9eaf-a805dae426fe"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4496),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Menos de una vez",
                            Order = 1,
                            QuestionId = new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5")
                        },
                        new
                        {
                            Id = new Guid("c4df8758-2fc8-4277-8a5d-e2b76a3319a0"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4498),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "De 1 a 3 veces",
                            Order = 2,
                            QuestionId = new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5")
                        },
                        new
                        {
                            Id = new Guid("59b840ad-869c-4517-be8d-21644e125c92"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4501),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "De 4 a 6 veces",
                            Order = 3,
                            QuestionId = new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5")
                        },
                        new
                        {
                            Id = new Guid("3926bb9c-4232-4d09-8f17-554c40be3fdd"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4504),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Más de 6 veces",
                            Order = 4,
                            QuestionId = new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5")
                        },
                        new
                        {
                            Id = new Guid("b2cbbe07-d0b2-4e47-a815-a32d7c283189"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4506),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Italiana",
                            Order = 1,
                            QuestionId = new Guid("6cf7f688-b896-4c24-97ca-09eaca788680")
                        },
                        new
                        {
                            Id = new Guid("0de3a2c2-6bc1-4377-9dac-6388ec8c2fd0"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4508),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Mexicana",
                            Order = 2,
                            QuestionId = new Guid("6cf7f688-b896-4c24-97ca-09eaca788680")
                        },
                        new
                        {
                            Id = new Guid("d22f76ae-5d1d-42ac-85fd-cd5a2aa8e7d4"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4510),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "China",
                            Order = 3,
                            QuestionId = new Guid("6cf7f688-b896-4c24-97ca-09eaca788680")
                        },
                        new
                        {
                            Id = new Guid("49431509-9eb5-4488-ab78-74da672f8fa1"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4512),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "India",
                            Order = 4,
                            QuestionId = new Guid("6cf7f688-b896-4c24-97ca-09eaca788680")
                        },
                        new
                        {
                            Id = new Guid("309239c3-3919-4f61-9ad9-35791b5219fe"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4513),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Menos de 1 porción",
                            Order = 1,
                            QuestionId = new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2")
                        },
                        new
                        {
                            Id = new Guid("28f46940-7f4a-4d6b-b7ea-afe23044acf5"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4515),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "De 1 a 2 porciones",
                            Order = 2,
                            QuestionId = new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2")
                        },
                        new
                        {
                            Id = new Guid("cb7afa45-856c-4658-a300-dc8c456e1dc9"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4517),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "De 3 a 4 porciones",
                            Order = 3,
                            QuestionId = new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2")
                        },
                        new
                        {
                            Id = new Guid("6a0e9386-3d0d-4608-90df-0d4573779bdf"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4518),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Más de 4 porciones",
                            Order = 4,
                            QuestionId = new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2")
                        },
                        new
                        {
                            Id = new Guid("3afa3c45-2a45-4550-bf31-7483a9dc5dca"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4520),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Pastel de chocolate",
                            Order = 1,
                            QuestionId = new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3")
                        },
                        new
                        {
                            Id = new Guid("c7f37b78-d8df-45a8-99f7-5bb5b5553625"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4522),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Helado",
                            Order = 2,
                            QuestionId = new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3")
                        },
                        new
                        {
                            Id = new Guid("6d0efe10-06cd-4f63-816e-2879ac6c910e"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4524),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Frutas frescas",
                            Order = 3,
                            QuestionId = new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3")
                        },
                        new
                        {
                            Id = new Guid("6daa26db-08b4-4067-a0c3-4a16ef7def49"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4527),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Flan",
                            Order = 4,
                            QuestionId = new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3")
                        });
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnswerTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VersionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnswerTypeId");

                    b.HasIndex("VersionId");

                    b.ToTable("Question", "Sur");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"),
                            AnswerTypeId = new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6708),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "¿Cuál es tu comida favorita?",
                            Order = 1,
                            Required = true,
                            VersionId = new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3")
                        },
                        new
                        {
                            Id = new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"),
                            AnswerTypeId = new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6715),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "¿Cuántas veces a la semana sueles comer comida rápida?",
                            Order = 2,
                            Required = true,
                            VersionId = new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3")
                        },
                        new
                        {
                            Id = new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"),
                            AnswerTypeId = new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6719),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "Si tuvieras que elegir solo un tipo de comida para comer durante un mes, ¿cuál sería?",
                            Order = 3,
                            Required = true,
                            VersionId = new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3")
                        },
                        new
                        {
                            Id = new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"),
                            AnswerTypeId = new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6722),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "¿Cuántas porciones de frutas y verduras consumes al día, en promedio?",
                            Order = 4,
                            Required = true,
                            VersionId = new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3")
                        },
                        new
                        {
                            Id = new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"),
                            AnswerTypeId = new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6724),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "¿Cuál es tu postre favorito?",
                            Order = 5,
                            Required = true,
                            VersionId = new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3")
                        },
                        new
                        {
                            Id = new Guid("e5ecdf94-87f5-4b15-9a09-3f80e2d9ead2"),
                            AnswerTypeId = new Guid("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6729),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            IsActive = true,
                            IsDeleted = false,
                            Label = "¿Cuántas horas a la semana dedicas a realizar ejercicio físico?",
                            Order = 6,
                            Required = true,
                            VersionId = new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3")
                        });
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Survey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Survey", "Sur");

                    b.HasData(
                        new
                        {
                            Id = new Guid("de22342c-777b-4037-ba79-a31ac7c4e6fd"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 32, DateTimeKind.Utc).AddTicks(5663),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            Description = "Esta encuesta tiene como objetivo recopilar las preferencias de comida de los usuarios. Los participantes deberán responder una serie de preguntas relacionadas con diferentes tipos de alimentos y realizar algunos cálculos matemáticos simples.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Preferencias de comida"
                        });
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Version", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("SurveyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Version", "Sur");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"),
                            CreatedAt = new DateTime(2023, 6, 11, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(3958),
                            CreatedBy = new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                            From = new DateTime(2023, 6, 11, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(3932),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Default",
                            SurveyId = new Guid("de22342c-777b-4037-ba79-a31ac7c4e6fd"),
                            To = new DateTime(2023, 6, 16, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(3933)
                        });
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Answer", b =>
                {
                    b.HasOne("Surveys.Domain.Surveys.Option", "Option")
                        .WithMany("Answers")
                        .HasForeignKey("OptionId");

                    b.HasOne("Surveys.Domain.Surveys.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Surveys.Domain.Surveys.Survey", "Survey")
                        .WithMany("Answers")
                        .HasForeignKey("SurveyId")
                        .IsRequired();

                    b.HasOne("Surveys.Domain.Surveys.Version", "Version")
                        .WithMany("Answers")
                        .HasForeignKey("VersionId")
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Question");

                    b.Navigation("Survey");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Option", b =>
                {
                    b.HasOne("Surveys.Domain.Surveys.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Question", b =>
                {
                    b.HasOne("Surveys.Domain.Surveys.AnswerType", "AnswerType")
                        .WithMany("Questions")
                        .HasForeignKey("AnswerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Surveys.Domain.Surveys.Version", "Version")
                        .WithMany("Questions")
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnswerType");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Version", b =>
                {
                    b.HasOne("Surveys.Domain.Surveys.Survey", "Survey")
                        .WithMany("Versions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.AnswerType", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Option", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Options");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Survey", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Versions");
                });

            modelBuilder.Entity("Surveys.Domain.Surveys.Version", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}