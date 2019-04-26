using Microsoft.EntityFrameworkCore.Migrations;

namespace DM_helper.Migrations
{
    public partial class addingarchetypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ArchetypeID",
                table: "Weapons",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ArchetypeID",
                table: "Skills",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ArchetypeID",
                table: "Melee",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ArchetypeID",
                table: "Foci",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ArchetypeID",
                table: "Equipment",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ArchetypeID",
                table: "Armor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_ArchetypeID",
                table: "Weapons",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ArchetypeID",
                table: "Skills",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Melee_ArchetypeID",
                table: "Melee",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Foci_ArchetypeID",
                table: "Foci",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ArchetypeID",
                table: "Equipment",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Armor_ArchetypeID",
                table: "Armor",
                column: "ArchetypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Armor_ArmorArchetype_ArchetypeID",
                table: "Armor",
                column: "ArchetypeID",
                principalTable: "ArmorArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_ArmorArchetype_ArchetypeID",
                table: "Equipment",
                column: "ArchetypeID",
                principalTable: "ArmorArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foci_ArmorArchetype_ArchetypeID",
                table: "Foci",
                column: "ArchetypeID",
                principalTable: "ArmorArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Melee_ArmorArchetype_ArchetypeID",
                table: "Melee",
                column: "ArchetypeID",
                principalTable: "ArmorArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_ArmorArchetype_ArchetypeID",
                table: "Skills",
                column: "ArchetypeID",
                principalTable: "ArmorArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_ArmorArchetype_ArchetypeID",
                table: "Weapons",
                column: "ArchetypeID",
                principalTable: "ArmorArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armor_ArmorArchetype_ArchetypeID",
                table: "Armor");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_ArmorArchetype_ArchetypeID",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Foci_ArmorArchetype_ArchetypeID",
                table: "Foci");

            migrationBuilder.DropForeignKey(
                name: "FK_Melee_ArmorArchetype_ArchetypeID",
                table: "Melee");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_ArmorArchetype_ArchetypeID",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_ArmorArchetype_ArchetypeID",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_ArchetypeID",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ArchetypeID",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Melee_ArchetypeID",
                table: "Melee");

            migrationBuilder.DropIndex(
                name: "IX_Foci_ArchetypeID",
                table: "Foci");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_ArchetypeID",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Armor_ArchetypeID",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Melee");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Foci");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Armor");
        }
    }
}
