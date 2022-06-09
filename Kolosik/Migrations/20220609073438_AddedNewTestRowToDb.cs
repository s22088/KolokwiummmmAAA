using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium2.Migrations
{
    public partial class AddedNewTestRowToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "IdTrack", "Duration", "IdMusicAlbum_FK", "TrackName" },
                values: new object[] { 11, 3.1f, 1, "Papamobile" });

            migrationBuilder.InsertData(
                table: "Musican_Tracks",
                columns: new[] { "IdMusican", "IdTrack" },
                values: new object[] { 1, 11 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musican_Tracks",
                keyColumns: new[] { "IdMusican", "IdTrack" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "IdTrack",
                keyValue: 11);
        }
    }
}
