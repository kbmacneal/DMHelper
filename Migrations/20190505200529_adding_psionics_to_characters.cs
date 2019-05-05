using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DM_helper.Migrations
{
    public partial class adding_psionics_to_characters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PsionicAbilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    PsionicSchoolID = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: false),
                    ArchetypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsionicAbilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PsionicAbilities_PsionicSkillArchetypes_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "PsionicSkillArchetypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PsionicAbilities_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PsionicAbilities_PsionicSchools_PsionicSchoolID",
                        column: x => x.PsionicSchoolID,
                        principalTable: "PsionicSchools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PsionicAbilities_ArchetypeID",
                table: "PsionicAbilities",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PsionicAbilities_CharacterID",
                table: "PsionicAbilities",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_PsionicAbilities_PsionicSchoolID",
                table: "PsionicAbilities",
                column: "PsionicSchoolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PsionicAbilities");
        }
    }
}
