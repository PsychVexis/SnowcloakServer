using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MareSynchronosServer.Migrations
{
    /// <inheritdoc />
    public partial class VariableSyncshellAndColours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "hex_allowed",
                table: "users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "hex_string",
                table: "users",
                type: "character varying(6)",
                maxLength: 6,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hex_string",
                table: "groups",
                type: "character varying(6)",
                maxLength: 6,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "size_override",
                table: "groups",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "special_login",
                table: "auth",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hex_allowed",
                table: "users");

            migrationBuilder.DropColumn(
                name: "hex_string",
                table: "users");

            migrationBuilder.DropColumn(
                name: "hex_string",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "size_override",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "special_login",
                table: "auth");
        }
    }
}
