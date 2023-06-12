using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surveys.Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sur");

            migrationBuilder.CreateTable(
                name: "AnswerType",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Survey",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurveyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Version_Survey_SurveyId",
                        column: x => x.SurveyId,
                        principalSchema: "Sur",
                        principalTable: "Survey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_AnswerType_AnswerTypeId",
                        column: x => x.AnswerTypeId,
                        principalSchema: "Sur",
                        principalTable: "AnswerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Question_Version_VersionId",
                        column: x => x.VersionId,
                        principalSchema: "Sur",
                        principalTable: "Version",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Option",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "Sur",
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                schema: "Sur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurveyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Option_OptionId",
                        column: x => x.OptionId,
                        principalSchema: "Sur",
                        principalTable: "Option",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "Sur",
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answer_Survey_SurveyId",
                        column: x => x.SurveyId,
                        principalSchema: "Sur",
                        principalTable: "Survey",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Answer_Version_VersionId",
                        column: x => x.VersionId,
                        principalSchema: "Sur",
                        principalTable: "Version",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "AnswerType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"), new DateTime(2023, 6, 8, 20, 43, 44, 51, DateTimeKind.Utc).AddTicks(9247), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Open", null },
                    { new Guid("70a469f8-d412-4297-83b0-478e6407c298"), new DateTime(2023, 6, 8, 20, 43, 44, 51, DateTimeKind.Utc).AddTicks(9240), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Option", null }
                });

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "IsActive", "IsAdmin", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a983bf9b-049e-4fdb-83e9-0d079d5d7b6d"), new DateTime(2023, 6, 8, 20, 43, 44, 53, DateTimeKind.Utc).AddTicks(9525), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, false, "Participant", null },
                    { new Guid("c4a19c91-574d-403f-ae8c-131d36f275d6"), new DateTime(2023, 6, 8, 20, 43, 44, 53, DateTimeKind.Utc).AddTicks(9482), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, true, false, "Interview", null }
                });

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "Survey",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { new Guid("de22342c-777b-4037-ba79-a31ac7c4e6fd"), new DateTime(2023, 6, 8, 20, 43, 44, 54, DateTimeKind.Utc).AddTicks(1064), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, "Esta encuesta tiene como objetivo recopilar las preferencias de comida de los usuarios. Los participantes deberán responder una serie de preguntas relacionadas con diferentes tipos de alimentos y realizar algunos cálculos matemáticos simples.", true, false, "Preferencias de comida", null });

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), new DateTime(2023, 6, 8, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(4338), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, "skyrockcorp@gmail.com", true, false, "Jonathan Mite", null });

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "Version",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "From", "IsActive", "IsDeleted", "Name", "SurveyId", "To", "UpdatedAt" },
                values: new object[] { new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"), new DateTime(2023, 6, 8, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(5583), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, new DateTime(2023, 6, 8, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(5550), true, false, "001", new Guid("de22342c-777b-4037-ba79-a31ac7c4e6fd"), new DateTime(2023, 6, 13, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(5550), null });

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "Question",
                columns: new[] { "Id", "AnswerTypeId", "CreatedAt", "CreatedBy", "DeletedAt", "IsActive", "IsDeleted", "Label", "Order", "Required", "UpdatedAt", "VersionId" },
                values: new object[,]
                {
                    { new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), new Guid("70a469f8-d412-4297-83b0-478e6407c298"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3559), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "¿Cuál es tu postre favorito?", 5, true, null, new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3") },
                    { new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), new Guid("70a469f8-d412-4297-83b0-478e6407c298"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3310), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "¿Cuántas veces a la semana sueles comer comida rápida?", 2, true, null, new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3") },
                    { new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"), new Guid("70a469f8-d412-4297-83b0-478e6407c298"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3542), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Si tuvieras que elegir solo un tipo de comida para comer durante un mes, ¿cuál sería?", 3, true, null, new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3") },
                    { new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"), new Guid("70a469f8-d412-4297-83b0-478e6407c298"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3295), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "¿Cuál es tu comida favorita?", 1, true, null, new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3") },
                    { new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), new Guid("70a469f8-d412-4297-83b0-478e6407c298"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3550), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "¿Cuántas porciones de frutas y verduras consumes al día, en promedio?", 4, true, null, new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3") },
                    { new Guid("e5ecdf94-87f5-4b15-9a09-3f80e2d9ead2"), new Guid("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3566), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "¿Cuántas horas a la semana dedicas a realizar ejercicio físico?", 6, true, null, new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3") }
                });

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "Option",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "IsActive", "IsDeleted", "Label", "Order", "QuestionId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0de3a2c2-6bc1-4377-9dac-6388ec8c2fd0"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(493), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Mexicana", 2, new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"), null },
                    { new Guid("28f46940-7f4a-4d6b-b7ea-afe23044acf5"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(505), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "De 1 a 2 porciones", 2, new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), null },
                    { new Guid("309239c3-3919-4f61-9ad9-35791b5219fe"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(503), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Menos de 1 porción", 1, new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), null },
                    { new Guid("3926bb9c-4232-4d09-8f17-554c40be3fdd"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(487), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Más de 6 veces", 4, new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), null },
                    { new Guid("3afa3c45-2a45-4550-bf31-7483a9dc5dca"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(513), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Pastel de chocolate", 1, new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), null },
                    { new Guid("49431509-9eb5-4488-ab78-74da672f8fa1"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(499), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "India", 4, new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"), null },
                    { new Guid("59b840ad-869c-4517-be8d-21644e125c92"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(484), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "De 4 a 6 veces", 3, new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), null },
                    { new Guid("5d4059ac-b72a-4dd5-8b9f-0e287a450884"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(413), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Sushi", 3, new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"), null },
                    { new Guid("6a0e9386-3d0d-4608-90df-0d4573779bdf"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(510), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Más de 4 porciones", 4, new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), null },
                    { new Guid("6d0efe10-06cd-4f63-816e-2879ac6c910e"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(521), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Frutas frescas", 3, new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), null },
                    { new Guid("6daa26db-08b4-4067-a0c3-4a16ef7def49"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(524), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Flan", 4, new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), null },
                    { new Guid("91b15628-d3d2-444d-9eaf-a805dae426fe"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(475), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Menos de una vez", 1, new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), null },
                    { new Guid("98a77a34-5ce4-487b-830c-8c78652a84dd"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(416), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Ensalada", 4, new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"), null },
                    { new Guid("b2cbbe07-d0b2-4e47-a815-a32d7c283189"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(489), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Italiana", 1, new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"), null },
                    { new Guid("c4df8758-2fc8-4277-8a5d-e2b76a3319a0"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(480), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "De 1 a 3 veces", 2, new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"), null },
                    { new Guid("c7f37b78-d8df-45a8-99f7-5bb5b5553625"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(518), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Helado", 2, new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"), null },
                    { new Guid("cb7afa45-856c-4658-a300-dc8c456e1dc9"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(508), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "De 3 a 4 porciones", 3, new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"), null },
                    { new Guid("d22f76ae-5d1d-42ac-85fd-cd5a2aa8e7d4"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(496), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "China", 3, new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"), null },
                    { new Guid("f069ef5a-107c-4dc9-a629-1a0702976d8d"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(399), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Pizza", 1, new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"), null },
                    { new Guid("fdf913cb-ccb4-4f91-ac73-c0b78d8142da"), new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(409), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, "Hamburguesa", 2, new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_OptionId",
                schema: "Sur",
                table: "Answer",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                schema: "Sur",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_SurveyId",
                schema: "Sur",
                table: "Answer",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_VersionId",
                schema: "Sur",
                table: "Answer",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_QuestionId",
                schema: "Sur",
                table: "Option",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_AnswerTypeId",
                schema: "Sur",
                table: "Question",
                column: "AnswerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_VersionId",
                schema: "Sur",
                table: "Question",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Version_SurveyId",
                schema: "Sur",
                table: "Version",
                column: "SurveyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer",
                schema: "Sur");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Sur");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Sur");

            migrationBuilder.DropTable(
                name: "Option",
                schema: "Sur");

            migrationBuilder.DropTable(
                name: "Question",
                schema: "Sur");

            migrationBuilder.DropTable(
                name: "AnswerType",
                schema: "Sur");

            migrationBuilder.DropTable(
                name: "Version",
                schema: "Sur");

            migrationBuilder.DropTable(
                name: "Survey",
                schema: "Sur");
        }
    }
}
