using Microsoft.EntityFrameworkCore.Migrations;

namespace DM_helper.Migrations
{
    public partial class fixing_relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEncounter_Character_ID",
                table: "CharacterEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEncounter_Encounter_ID",
                table: "CharacterEncounter");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEncounter_CharacterID",
                table: "CharacterEncounter",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEncounter_EncounterID",
                table: "CharacterEncounter",
                column: "EncounterID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEncounter_Character_CharacterID",
                table: "CharacterEncounter",
                column: "CharacterID",
                principalTable: "Character",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEncounter_Encounter_EncounterID",
                table: "CharacterEncounter",
                column: "EncounterID",
                principalTable: "Encounter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEncounter_Character_CharacterID",
                table: "CharacterEncounter");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEncounter_Encounter_EncounterID",
                table: "CharacterEncounter");

            migrationBuilder.DropIndex(
                name: "IX_CharacterEncounter_CharacterID",
                table: "CharacterEncounter");

            migrationBuilder.DropIndex(
                name: "IX_CharacterEncounter_EncounterID",
                table: "CharacterEncounter");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEncounter_Character_ID",
                table: "CharacterEncounter",
                column: "ID",
                principalTable: "Character",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEncounter_Encounter_ID",
                table: "CharacterEncounter",
                column: "ID",
                principalTable: "Encounter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
