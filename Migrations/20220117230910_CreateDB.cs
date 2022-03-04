using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_201810088.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drawers",
                columns: table => new
                {
                    DrawerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPerManga = table.Column<double>(type: "float", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawers", x => x.DrawerId);
                });

            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NoOfEpisodes = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.MangaId);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MangaId = table.Column<int>(type: "int", nullable: false),
                    DrawerId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AirsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkId);
                    table.ForeignKey(
                        name: "FK_Works_Drawers_DrawerId",
                        column: x => x.DrawerId,
                        principalTable: "Drawers",
                        principalColumn: "DrawerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Works_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "MangaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drawers",
                columns: new[] { "DrawerId", "CostPerManga", "EmailAddress", "Name", "PhoneNumber", "ProfilePicture" },
                values: new object[,]
                {
                    { 1, 15.0, "Drawer1@gmail.com", "Drawer 1", "+962779783215", "/Images/Drawer" },
                    { 2, 20.0, "Drawer2@gmail.com", "Drawer 2", "+962779783220", "/Images/Drawer" },
                    { 3, 35.0, "Drawer3@gmail.com", "Drawer 3", "+962779783235", "/Images/Drawer" },
                    { 4, 40.0, "Drawer4@gmail.com", "Drawer 4", "+962779783240", "/Images/Drawer" },
                    { 5, 55.0, "Drawer5@gmail.com", "Drawer 5", "+962779783255", "/Images/Drawer" }
                });

            migrationBuilder.InsertData(
                table: "Mangas",
                columns: new[] { "MangaId", "CoverImage", "Description", "Name", "NoOfEpisodes" },
                values: new object[,]
                {
                    { 1, null, "it is a 24 Episodes anime", "Manga 1", 24 },
                    { 2, null, "it is a 32 Episodes anime", "Manga 2", 32 },
                    { 3, null, "it is a 40 Episodes anime", "Manga 3", 40 },
                    { 4, null, "it is a 60 Episodes anime", "Manga 4", 60 },
                    { 5, null, "it is a 12 Episodes anime", "Manga 5", 12 }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "AirsAt", "DrawerId", "EndDate", "MangaId", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 18, 6, 9, 9, 350, DateTimeKind.Local).AddTicks(7336), 1, new DateTime(2022, 1, 16, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(6577), 1, new DateTime(2022, 1, 11, 1, 9, 9, 341, DateTimeKind.Local).AddTicks(9014), 0 },
                    { 4, new DateTime(2022, 1, 18, 3, 9, 9, 350, DateTimeKind.Local).AddTicks(8678), 3, new DateTime(2022, 2, 2, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8675), 1, new DateTime(2022, 1, 25, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8670), 0 },
                    { 2, new DateTime(2022, 1, 18, 9, 9, 9, 350, DateTimeKind.Local).AddTicks(8651), 2, new DateTime(2022, 1, 20, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8645), 2, new DateTime(2022, 1, 17, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8623), 2 },
                    { 3, new DateTime(2022, 1, 17, 22, 9, 9, 350, DateTimeKind.Local).AddTicks(8665), 3, new DateTime(2022, 1, 28, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8661), 3, new DateTime(2022, 1, 25, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8657), 1 },
                    { 5, new DateTime(2022, 1, 18, 2, 9, 9, 350, DateTimeKind.Local).AddTicks(8691), 1, new DateTime(2022, 2, 2, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8687), 3, new DateTime(2022, 1, 13, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8683), 1 },
                    { 6, new DateTime(2022, 1, 18, 5, 9, 9, 350, DateTimeKind.Local).AddTicks(8704), 4, new DateTime(2022, 2, 1, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8700), 4, new DateTime(2022, 1, 11, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8696), 1 },
                    { 7, new DateTime(2022, 1, 18, 8, 9, 9, 350, DateTimeKind.Local).AddTicks(8716), 5, new DateTime(2022, 1, 21, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8712), 4, new DateTime(2022, 1, 16, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8708), 2 },
                    { 8, new DateTime(2022, 1, 18, 6, 9, 9, 350, DateTimeKind.Local).AddTicks(8732), 1, new DateTime(2022, 1, 15, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8728), 5, new DateTime(2022, 1, 10, 1, 9, 9, 350, DateTimeKind.Local).AddTicks(8724), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Works_DrawerId",
                table: "Works",
                column: "DrawerId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_MangaId",
                table: "Works",
                column: "MangaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Drawers");

            migrationBuilder.DropTable(
                name: "Mangas");
        }
    }
}
