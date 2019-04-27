using Microsoft.EntityFrameworkCore.Migrations;

namespace DM_helper.Migrations
{
    public partial class fixing_archetypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "ArchetypeID",
                table: "Weapons",
                nullable: true,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArchetypeID",
                table: "Skills",
                nullable: true,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArchetypeID",
                table: "Genders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArchetypeID",
                table: "Foci",
                nullable: true,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArchetypeID",
                table: "CharacterClasses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArchetypeID",
                table: "Backgrounds",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genders_ArchetypeID",
                table: "Genders",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_ArchetypeID",
                table: "CharacterClasses",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_ArchetypeID",
                table: "Backgrounds",
                column: "ArchetypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_BackgroundArchetype_ArchetypeID",
                table: "Backgrounds",
                column: "ArchetypeID",
                principalTable: "BackgroundArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterClasses_CharacterClasses_ArchetypeID",
                table: "CharacterClasses",
                column: "ArchetypeID",
                principalTable: "CharacterClasses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_EquipmentArchetype_ArchetypeID",
                table: "Equipment",
                column: "ArchetypeID",
                principalTable: "EquipmentArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foci_FociArchetype_ArchetypeID",
                table: "Foci",
                column: "ArchetypeID",
                principalTable: "FociArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_GenderArchetype_ArchetypeID",
                table: "Genders",
                column: "ArchetypeID",
                principalTable: "GenderArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Melee_MeleeArchetype_ArchetypeID",
                table: "Melee",
                column: "ArchetypeID",
                principalTable: "MeleeArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillsArchetype_ArchetypeID",
                table: "Skills",
                column: "ArchetypeID",
                principalTable: "SkillsArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_WeaponArchetype_ArchetypeID",
                table: "Weapons",
                column: "ArchetypeID",
                principalTable: "WeaponArchetype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_BackgroundArchetype_ArchetypeID",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterClasses_CharacterClasses_ArchetypeID",
                table: "CharacterClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_EquipmentArchetype_ArchetypeID",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Foci_FociArchetype_ArchetypeID",
                table: "Foci");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_GenderArchetype_ArchetypeID",
                table: "Genders");

            migrationBuilder.DropForeignKey(
                name: "FK_Melee_MeleeArchetype_ArchetypeID",
                table: "Melee");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillsArchetype_ArchetypeID",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_WeaponArchetype_ArchetypeID",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Genders_ArchetypeID",
                table: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_CharacterClasses_ArchetypeID",
                table: "CharacterClasses");

            migrationBuilder.DropIndex(
                name: "IX_Backgrounds_ArchetypeID",
                table: "Backgrounds");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "ArchetypeID",
                table: "Backgrounds");

            migrationBuilder.AlterColumn<long>(
                name: "ArchetypeID",
                table: "Weapons",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ArchetypeID",
                table: "Skills",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ArchetypeID",
                table: "Foci",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
