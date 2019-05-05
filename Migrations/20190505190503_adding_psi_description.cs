using Microsoft.EntityFrameworkCore.Migrations;

namespace DM_helper.Migrations
{
    public partial class adding_psi_description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PsionicSkillArchetypes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PsionicSkillArchetypes");
        }
    }
}
