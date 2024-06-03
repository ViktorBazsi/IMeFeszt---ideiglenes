using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMeFeszt.Migrations
{
    /// <inheritdoc />
    public partial class AddAmount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Donaters",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Donaters");
        }
    }
}
