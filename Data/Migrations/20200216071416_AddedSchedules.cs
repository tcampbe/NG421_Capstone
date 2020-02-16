using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class AddedSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    English = table.Column<string>(nullable: true),
                    Math = table.Column<string>(nullable: true),
                    Science = table.Column<string>(nullable: true),
                    SocialStudies = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { 1, "Abeka", "Math-U-See", "Beautiful Feet", "Sonlight" });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { 2, "Alpha Omega", "Miquon", "Bob Jones", "Ted-ed" });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { 3, "Apologia", "Saxon", "edX", "Coursera" });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { 4, "Free-Ed", "Kahn academy Online", "Udemy", "Hillsdale College Free Online" });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "English", "Math", "Science", "SocialStudies" },
                values: new object[] { 5, "Rosetta Stone", "Christian Liberty Press", "Codeacademy", "Stanford Online" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
