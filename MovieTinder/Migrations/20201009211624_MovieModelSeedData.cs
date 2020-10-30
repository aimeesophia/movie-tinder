using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTinder.Migrations
{
    public partial class MovieModelSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Jack Skellington, king of Halloween Town, discovers Christmas Town, but his attempts to bring Christmas to his home causes confusion.", "The Nightmare Before Christmas" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 2, "Four weeks after a mysterious, incurable virus spreads throughout the UK, a handful of survivors try to find sanctuary.", "28 Days Later" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 3, "A young widow discovers that her late husband has left her 10 messages intended to help ease her pain and start a new life.", "P.S. I Love You" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
