using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbMusicList.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenereId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenereId);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<float>(type: "real", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenereId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistsAndSongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistsAndSongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistsAndSongs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistsAndSongs_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "DateOfBirth", "DateOfDeath", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1958, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madonna@gmail.com", "https://www.instagram.com/madonna/", "Madonna", "+38-093-73-01-064" },
                    { 2, new DateTime(1988, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adele@gmail.com", "https://www.instagram.com/adele/", "Adele", "+38-067-85-19-589" },
                    { 3, new DateTime(1946, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Freddie Mercury", null },
                    { 4, new DateTime(1958, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://www.instagram.com/prince/?hl=uk", "Prince", null },
                    { 5, new DateTime(1983, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://www.instagram.com/amywinehouse/?hl=uk", "Amy Winehouse", null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenereId", "Title" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "POP" },
                    { 3, "R&B" },
                    { 4, "Funk" },
                    { 5, "Soul" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, 5.55f, 1, new DateTime(1975, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bohemian Rhapsody" },
                    { 2, 4.3f, 4, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uptown Funk" },
                    { 3, 4.54f, 3, new DateTime(1983, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billie Jean" },
                    { 4, 4.36f, 2, new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hallelujah" },
                    { 5, 3.56f, 3, new DateTime(2003, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crazy in Love" }
                });

            migrationBuilder.InsertData(
                table: "ArtistsAndSongs",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 1 },
                    { 5, 2, 3 },
                    { 6, 2, 5 },
                    { 7, 3, 2 },
                    { 8, 3, 4 },
                    { 9, 3, 5 },
                    { 10, 4, 2 },
                    { 11, 4, 4 },
                    { 12, 4, 3 },
                    { 13, 5, 1 },
                    { 14, 5, 2 },
                    { 15, 5, 3 },
                    { 16, 5, 4 },
                    { 17, 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistsAndSongs_ArtistId",
                table: "ArtistsAndSongs",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistsAndSongs_SongId",
                table: "ArtistsAndSongs",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistsAndSongs");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
