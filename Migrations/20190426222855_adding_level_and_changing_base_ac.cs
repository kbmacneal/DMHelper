using Microsoft.EntityFrameworkCore.Migrations;

namespace DM_helper.Migrations
{
    public partial class adding_level_and_changing_base_ac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ac",
                table: "Character",
                newName: "level");

            migrationBuilder.AddColumn<int>(
                name: "baseac",
                table: "Character",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "baseac",
                table: "Character");

            migrationBuilder.RenameColumn(
                name: "level",
                table: "Character",
                newName: "ac");
        }
    }
}
