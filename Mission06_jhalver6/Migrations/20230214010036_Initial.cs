using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_jhalver6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Movieid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Movieid);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Movieid", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Adventure", "Kevin Reynolds", false, null, null, "PG-13", "The Count of Monte Cristo", 2002 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Movieid", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Romantic Comedy", "Andy Tennant", false, null, null, "PG-13", "Hitch", 2005 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Movieid", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action", "Christopher Nolan", false, null, null, "PG-13", "The Dark Knight", 2008 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
