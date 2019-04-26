using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DM_helper.Migrations
{
    public partial class initial : Migration
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
                name: "Character",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    faction = table.Column<string>(nullable: true),
                    homeworld = table.Column<string>(nullable: true),
                    currenthp = table.Column<int>(nullable: false),
                    maxhp = table.Column<int>(nullable: false),
                    currentsystemstrain = table.Column<int>(nullable: false),
                    maxsystemstrain = table.Column<int>(nullable: false),
                    permanentstrain = table.Column<int>(nullable: false),
                    currentxp = table.Column<int>(nullable: false),
                    xptilnextlevel = table.Column<int>(nullable: false),
                    ac = table.Column<int>(nullable: false),
                    atkbonus = table.Column<int>(nullable: false),
                    strength = table.Column<int>(nullable: false),
                    dexterity = table.Column<int>(nullable: false),
                    constitution = table.Column<int>(nullable: false),
                    intelligence = table.Column<int>(nullable: false),
                    wisdom = table.Column<int>(nullable: false),
                    charisma = table.Column<int>(nullable: false),
                    credits = table.Column<int>(nullable: false),
                    goals = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.ID);
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

            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    ac = table.Column<int>(nullable: false),
                    cost = table.Column<long>(nullable: false),
                    encumbrance = table.Column<long>(nullable: false),
                    techlevel = table.Column<long>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Armor_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClasses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterClasses_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    cost = table.Column<string>(nullable: true),
                    encumbrance = table.Column<string>(nullable: true),
                    techlevel = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipment_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foci",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foci", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foci_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Genders_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Melee",
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
                    techlevel = table.Column<long>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Melee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Melee_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    specialist = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skills_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
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
                    techlevel = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Weapons_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armor_CharacterID",
                table: "Armor",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_CharacterID",
                table: "Backgrounds",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_CharacterID",
                table: "CharacterClasses",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CharacterID",
                table: "Equipment",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Foci_CharacterID",
                table: "Foci",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_CharacterID",
                table: "Genders",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Melee_CharacterID",
                table: "Melee",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterID",
                table: "Skills",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CharacterID",
                table: "Weapons",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "ArmorArchetype");

            migrationBuilder.DropTable(
                name: "BackgroundArchetype");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "CharacterClassArchetype");

            migrationBuilder.DropTable(
                name: "CharacterClasses");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "EquipmentArchetype");

            migrationBuilder.DropTable(
                name: "Foci");

            migrationBuilder.DropTable(
                name: "FociArchetype");

            migrationBuilder.DropTable(
                name: "GenderArchetype");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Melee");

            migrationBuilder.DropTable(
                name: "MeleeArchetype");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SkillsArchetype");

            migrationBuilder.DropTable(
                name: "WeaponArchetype");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Character");
        }
    }
}
