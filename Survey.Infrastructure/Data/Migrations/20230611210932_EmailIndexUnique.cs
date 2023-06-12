using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Surveys.Infrastructure.Data.Migrations
{
    public partial class EmailIndexUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sur",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a983bf9b-049e-4fdb-83e9-0d079d5d7b6d"));

            migrationBuilder.DeleteData(
                schema: "Sur",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c4a19c91-574d-403f-ae8c-131d36f275d6"));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "AnswerType",
                keyColumn: "Id",
                keyValue: new Guid("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "AnswerType",
                keyColumn: "Id",
                keyValue: new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("0de3a2c2-6bc1-4377-9dac-6388ec8c2fd0"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("28f46940-7f4a-4d6b-b7ea-afe23044acf5"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("309239c3-3919-4f61-9ad9-35791b5219fe"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("3926bb9c-4232-4d09-8f17-554c40be3fdd"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("3afa3c45-2a45-4550-bf31-7483a9dc5dca"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("49431509-9eb5-4488-ab78-74da672f8fa1"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("59b840ad-869c-4517-be8d-21644e125c92"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("5d4059ac-b72a-4dd5-8b9f-0e287a450884"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("6a0e9386-3d0d-4608-90df-0d4573779bdf"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("6d0efe10-06cd-4f63-816e-2879ac6c910e"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("6daa26db-08b4-4067-a0c3-4a16ef7def49"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("91b15628-d3d2-444d-9eaf-a805dae426fe"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("98a77a34-5ce4-487b-830c-8c78652a84dd"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("b2cbbe07-d0b2-4e47-a815-a32d7c283189"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("c4df8758-2fc8-4277-8a5d-e2b76a3319a0"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("c7f37b78-d8df-45a8-99f7-5bb5b5553625"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("cb7afa45-856c-4658-a300-dc8c456e1dc9"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("d22f76ae-5d1d-42ac-85fd-cd5a2aa8e7d4"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("f069ef5a-107c-4dc9-a629-1a0702976d8d"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("fdf913cb-ccb4-4f91-ac73-c0b78d8142da"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("e5ecdf94-87f5-4b15-9a09-3f80e2d9ead2"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 31, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "IsActive", "IsAdmin", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("09becc02-53dd-4b58-8775-381c005204fb"), new DateTime(2023, 6, 11, 21, 9, 32, 32, DateTimeKind.Utc).AddTicks(4682), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, true, false, "Interviewer", null },
                    { new Guid("db5c2f2d-9d4e-4852-9ff2-50ca32db738d"), new DateTime(2023, 6, 11, 21, 9, 32, 32, DateTimeKind.Utc).AddTicks(4795), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, false, "Participant", null }
                });

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Survey",
                keyColumn: "Id",
                keyValue: new Guid("de22342c-777b-4037-ba79-a31ac7c4e6fd"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 32, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 11, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Version",
                keyColumn: "Id",
                keyValue: new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"),
                columns: new[] { "CreatedAt", "From", "Name", "To" },
                values: new object[] { new DateTime(2023, 6, 11, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(3958), new DateTime(2023, 6, 11, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(3932), "Default", new DateTime(2023, 6, 16, 21, 9, 32, 33, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                schema: "Sur",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Email",
                schema: "Sur",
                table: "User");

            migrationBuilder.DeleteData(
                schema: "Sur",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("09becc02-53dd-4b58-8775-381c005204fb"));

            migrationBuilder.DeleteData(
                schema: "Sur",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("db5c2f2d-9d4e-4852-9ff2-50ca32db738d"));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "AnswerType",
                keyColumn: "Id",
                keyValue: new Guid("0ed9dbf2-f0d0-472a-b406-e1e00e85d9b3"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 51, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "AnswerType",
                keyColumn: "Id",
                keyValue: new Guid("70a469f8-d412-4297-83b0-478e6407c298"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 51, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("0de3a2c2-6bc1-4377-9dac-6388ec8c2fd0"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("28f46940-7f4a-4d6b-b7ea-afe23044acf5"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("309239c3-3919-4f61-9ad9-35791b5219fe"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("3926bb9c-4232-4d09-8f17-554c40be3fdd"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("3afa3c45-2a45-4550-bf31-7483a9dc5dca"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("49431509-9eb5-4488-ab78-74da672f8fa1"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("59b840ad-869c-4517-be8d-21644e125c92"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("5d4059ac-b72a-4dd5-8b9f-0e287a450884"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("6a0e9386-3d0d-4608-90df-0d4573779bdf"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("6d0efe10-06cd-4f63-816e-2879ac6c910e"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("6daa26db-08b4-4067-a0c3-4a16ef7def49"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("91b15628-d3d2-444d-9eaf-a805dae426fe"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("98a77a34-5ce4-487b-830c-8c78652a84dd"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("b2cbbe07-d0b2-4e47-a815-a32d7c283189"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("c4df8758-2fc8-4277-8a5d-e2b76a3319a0"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("c7f37b78-d8df-45a8-99f7-5bb5b5553625"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("cb7afa45-856c-4658-a300-dc8c456e1dc9"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("d22f76ae-5d1d-42ac-85fd-cd5a2aa8e7d4"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("f069ef5a-107c-4dc9-a629-1a0702976d8d"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Option",
                keyColumn: "Id",
                keyValue: new Guid("fdf913cb-ccb4-4f91-ac73-c0b78d8142da"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("075d33c3-25b1-4afb-98dd-3e8eb2c899c3"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("394db463-a6d2-47d2-b7eb-6d5d798d95e5"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("6cf7f688-b896-4c24-97ca-09eaca788680"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("8feb3112-f8f3-41b5-862b-bd35b899c96e"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("e5be98ee-7aa9-47c2-9783-8994e3ff15f2"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Question",
                keyColumn: "Id",
                keyValue: new Guid("e5ecdf94-87f5-4b15-9a09-3f80e2d9ead2"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 52, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.InsertData(
                schema: "Sur",
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "IsActive", "IsAdmin", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a983bf9b-049e-4fdb-83e9-0d079d5d7b6d"), new DateTime(2023, 6, 8, 20, 43, 44, 53, DateTimeKind.Utc).AddTicks(9525), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, false, false, "Participant", null },
                    { new Guid("c4a19c91-574d-403f-ae8c-131d36f275d6"), new DateTime(2023, 6, 8, 20, 43, 44, 53, DateTimeKind.Utc).AddTicks(9482), new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"), null, true, true, false, "Interview", null }
                });

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Survey",
                keyColumn: "Id",
                keyValue: new Guid("de22342c-777b-4037-ba79-a31ac7c4e6fd"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 54, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7a2346e2-4f06-4a6c-bf22-8a16b7a69c4c"),
                column: "CreatedAt",
                value: new DateTime(2023, 6, 8, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                schema: "Sur",
                table: "Version",
                keyColumn: "Id",
                keyValue: new Guid("90f67a44-ba40-4b32-a09a-25d2bcaa0ac3"),
                columns: new[] { "CreatedAt", "From", "Name", "To" },
                values: new object[] { new DateTime(2023, 6, 8, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(5583), new DateTime(2023, 6, 8, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(5550), "001", new DateTime(2023, 6, 13, 20, 43, 44, 55, DateTimeKind.Utc).AddTicks(5550) });
        }
    }
}
