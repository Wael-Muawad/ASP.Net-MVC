using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_201810088.Migrations
{
    public partial class EditSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 1,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Sui Ishida", "/Images/Drawer.jpg" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 2,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Eiichiro Oda", "/Images/Drawer.jpg" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 3,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Gosho Aoyama", "/Images/Drawer.jpg" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 4,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Akira Toriyama", "/Images/Drawer.jpg" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 5,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Tsugumi Ohba", "/Images/Drawer.jpg" });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 1,
                column: "Name",
                value: "Tokyo Ghoul");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 2,
                column: "Name",
                value: "One Piece");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 3,
                column: "Name",
                value: "Detective Conan");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 4,
                column: "Name",
                value: "Dragon Ball");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 5,
                column: "Name",
                value: "Death Note");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 1,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 6, 39, 43, 575, DateTimeKind.Local).AddTicks(3985), new DateTime(2022, 1, 16, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(2645), new DateTime(2022, 1, 11, 1, 39, 43, 558, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 2,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 9, 39, 43, 575, DateTimeKind.Local).AddTicks(6071), new DateTime(2022, 1, 20, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6061), new DateTime(2022, 1, 17, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 3,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 17, 22, 39, 43, 575, DateTimeKind.Local).AddTicks(6091), new DateTime(2022, 1, 28, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6085), new DateTime(2022, 1, 25, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 4,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 3, 39, 43, 575, DateTimeKind.Local).AddTicks(6109), new DateTime(2022, 2, 2, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 1, 25, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 5,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 2, 39, 43, 575, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 2, 2, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6121), new DateTime(2022, 1, 13, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 6,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 5, 39, 43, 575, DateTimeKind.Local).AddTicks(6147), new DateTime(2022, 2, 1, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6141), new DateTime(2022, 1, 11, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 7,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 8, 39, 43, 575, DateTimeKind.Local).AddTicks(6164), new DateTime(2022, 1, 21, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6159), new DateTime(2022, 1, 16, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: 8,
                columns: new[] { "AirsAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 18, 6, 39, 43, 575, DateTimeKind.Local).AddTicks(6182), new DateTime(2022, 1, 15, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6176), new DateTime(2022, 1, 10, 1, 39, 43, 575, DateTimeKind.Local).AddTicks(6171) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 1,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Drawer 1", "/Images/Drawer" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 2,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Drawer 2", "/Images/Drawer" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 3,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Drawer 3", "/Images/Drawer" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 4,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Drawer 4", "/Images/Drawer" });

            migrationBuilder.UpdateData(
                table: "Drawers",
                keyColumn: "DrawerId",
                keyValue: 5,
                columns: new[] { "Name", "ProfilePicture" },
                values: new object[] { "Drawer 5", "/Images/Drawer" });

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 1,
                column: "Name",
                value: "Manga 1");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 2,
                column: "Name",
                value: "Manga 2");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 3,
                column: "Name",
                value: "Manga 3");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 4,
                column: "Name",
                value: "Manga 4");

            migrationBuilder.UpdateData(
                table: "Mangas",
                keyColumn: "MangaId",
                keyValue: 5,
                column: "Name",
                value: "Manga 5");

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
    }
}
