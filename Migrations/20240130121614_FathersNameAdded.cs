using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class FathersNameAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "Students");
        }
    }
}
