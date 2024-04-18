using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor8App1.Migrations
{
    /// <inheritdoc />
    public partial class AddMammals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mammals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LatinName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mammals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mammals");
        }
    }
}
