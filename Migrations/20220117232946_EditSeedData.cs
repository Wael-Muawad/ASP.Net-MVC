using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_201810088.Migrations
{
    public partial class EditSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 1,
                column: "CostPerManga",
                value: 120.0);

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 2,
                column: "CostPerManga",
                value: 70.0);

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 1,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 6, 29, 44, 804, DateTimeKind.Local).AddTicks(5845), new DateTime(2022, 1, 16, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(5044), new DateTime(2022, 1, 11, 1, 29, 44, 791, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 2,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 9, 29, 44, 804, DateTimeKind.Local).AddTicks(7361), new DateTime(2022, 1, 20, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7355), new DateTime(2022, 1, 17, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 3,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 17, 22, 29, 44, 804, DateTimeKind.Local).AddTicks(7375), new DateTime(2022, 1, 28, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7371), new DateTime(2022, 1, 25, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 4,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 3, 29, 44, 804, DateTimeKind.Local).AddTicks(7387), new DateTime(2022, 2, 2, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7383), new DateTime(2022, 1, 25, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 5,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 2, 29, 44, 804, DateTimeKind.Local).AddTicks(7404), new DateTime(2022, 2, 2, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7395), new DateTime(2022, 1, 13, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 6,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 5, 29, 44, 804, DateTimeKind.Local).AddTicks(7416), new DateTime(2022, 2, 1, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7412), new DateTime(2022, 1, 11, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 7,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 8, 29, 44, 804, DateTimeKind.Local).AddTicks(7427), new DateTime(2022, 1, 21, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7423), new DateTime(2022, 1, 16, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 8,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 6, 29, 44, 804, DateTimeKind.Local).AddTicks(7439), new DateTime(2022, 1, 15, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7435), new DateTime(2022, 1, 10, 1, 29, 44, 804, DateTimeKind.Local).AddTicks(7431) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 1,
                column: "CostPerManga",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 2,
                column: "CostPerManga",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 1,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 6, 9, 9, 350, DateTimeKind.Local).AddTicks(7336), new DateTime(2022, 1, 16, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(6577), new DateTime(2022, 1, 11, 1, 9, 9, 341, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 2,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 9, 9, 9, 350, DateTimeKind.Local).AddTicks(8651), new DateTime(2022, 1, 20, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8645), new DateTime(2022, 1, 17, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 3,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 17, 22, 9, 9, 350, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 1, 28, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8661), new DateTime(2022, 1, 25, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 4,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 3, 9, 9, 350, DateTimeKind.Local).AddTicks(8678), new DateTime(2022, 2, 2, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8675), new DateTime(2022, 1, 25, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 5,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 2, 9, 9, 350, DateTimeKind.Local).AddTicks(8691), new DateTime(2022, 2, 2, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8687), new DateTime(2022, 1, 13, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 6,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 5, 9, 9, 350, DateTimeKind.Local).AddTicks(8704), new DateTime(2022, 2, 1, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 1, 11, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 7,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 8, 9, 9, 350, DateTimeKind.Local).AddTicks(8716), new DateTime(2022, 1, 21, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8712), new DateTime(2022, 1, 16, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 8,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 6, 9, 9, 350, DateTimeKind.Local).AddTicks(8732), new DateTime(2022, 1, 15, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8728), new DateTime(2022, 1, 10, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8724) });
        }
    }
}
