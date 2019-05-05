using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DM_helper.Migrations
{
    public partial class adding_psionics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PsionicSchools",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsionicSchools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PsionicSkillArchetypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    PsionicSchoolID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsionicSkillArchetypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PsionicSkillArchetypes_PsionicSchools_PsionicSchoolID",
                        column: x => x.PsionicSchoolID,
                        principalTable: "PsionicSchools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PsionicSkillArchetypes_PsionicSchoolID",
                table: "PsionicSkillArchetypes",
                column: "PsionicSchoolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PsionicSkillArchetypes");

            migrationBuilder.DropTable(
                name: "PsionicSchools");
        }
    }
}
