using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium2.Migrations
{
    public partial class Seeding_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MusicLabels",
                columns: new[] { "IdMusicLabel", "Name" },
                values: new object[] { 1, "Wadowicownia" });

            migrationBuilder.InsertData(
                table: "Musicans",
                columns: new[] { "IdMusican", "FirstName", "LastName", "Nickame" },
                values: new object[] { 1, "Karol", "Wojtyła", "Karol W." });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "IdAlbum", "AlbumName", "IdMusicLabel_FK", "PublishDate" },
                values: new object[] { 1, "2138", 1, new DateTime(2005, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "IdTrack", "Duration", "IdMusicAlbum_FK", "TrackName" },
                values: new object[] { 10, 5.2f, 1, "Miłość jest..." });

            migrationBuilder.InsertData(
                table: "Musican_Tracks",
                columns: new[] { "IdMusican", "IdTrack" },
                values: new object[] { 1, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musican_Tracks",
                keyColumns: new[] { "IdMusican", "IdTrack" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "IdMusican",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "IdTrack",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicLabels",
                keyColumn: "IdMusicLabel",
                keyValue: 1);
        }
    }
}
