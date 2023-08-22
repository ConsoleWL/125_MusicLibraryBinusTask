using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _125_MusicLibraryBinusTask.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Artist = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Album = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Genre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Like = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "Like", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "When", "Who", "Alternative", 0, new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9254), "Who is Who" },
                    { 2, "Long Time Ago", "Boney M", "80's", 0, new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9304), "Rasputin" },
                    { 3, "Shady", "Eminem", "Rap", 0, new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9306), "Bad Poetry" },
                    { 4, "Spicy Year", "Cury", "Folk", 0, new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9308), "Jimmi" },
                    { 5, "My Neighbours Never Sleep", "Scre Driver", "Heavy Metall", 0, new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9310), "Rusty Nails" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
