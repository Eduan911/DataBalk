using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabalkC_.Migrations
{
    /// <inheritdoc />
    public partial class AddJwtKeyToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JwtKey",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JwtKey",
                table: "Users");
        }
    }
}
