using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DM_helper.Migrations
{
    public partial class addingarchetypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArmorArchetype",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    ac = table.Column<int>(nullable: false),
                    cost = table.Column<long>(nullable: false),
                    encumbrance = table.Column<long>(nullable: false),
                    techlevel = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundArchetype",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClassArchetype",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClassArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentArchetype",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    cost = table.Column<string>(nullable: true),
                    encumbrance = table.Column<string>(nullable: true),
                    techlevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FociArchetype",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FociArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GenderArchetype",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MeleeArchetype",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    damage = table.Column<string>(nullable: true),
                    shockdamage = table.Column<string>(nullable: true),
                    attribute = table.Column<string>(nullable: true),
                    cost = table.Column<long>(nullable: false),
                    encumbrance = table.Column<long>(nullable: false),
                    techlevel = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeleeArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SkillsArchetype",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    specialist = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsArchetype", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WeaponArchetype",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    damage = table.Column<string>(nullable: true),
                    range = table.Column<string>(nullable: true),
                    cost = table.Column<string>(nullable: true),
                    magazine = table.Column<string>(nullable: true),
                    encumbrance = table.Column<string>(nullable: true),
                    attribute = table.Column<string>(nullable: true),
                    techlevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponArchetype", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorArchetype");

            migrationBuilder.DropTable(
                name: "BackgroundArchetype");

            migrationBuilder.DropTable(
                name: "CharacterClassArchetype");

            migrationBuilder.DropTable(
                name: "EquipmentArchetype");

            migrationBuilder.DropTable(
                name: "FociArchetype");

            migrationBuilder.DropTable(
                name: "GenderArchetype");

            migrationBuilder.DropTable(
                name: "MeleeArchetype");

            migrationBuilder.DropTable(
                name: "SkillsArchetype");

            migrationBuilder.DropTable(
                name: "WeaponArchetype");
        }
    }
}
