using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMeFeszt.Migrations
{
    /// <inheritdoc />
    public partial class AddDonaters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donaters",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donaters", x => new { x.Name, x.Email });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donaters");
        }
    }
}
