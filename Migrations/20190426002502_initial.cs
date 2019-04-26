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
                name: "Character",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    BackgroundID = table.Column<int>(nullable: true),
                    GenderID = table.Column<int>(nullable: true),
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
                    ArmorID = table.Column<long>(nullable: true),
                    goals = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.ID);
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
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Armor_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    characterid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Character_characterid",
                        column: x => x.characterid,
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
                    characterid = table.Column<int>(nullable: false),
                    CharacterID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterClasses_Character_characterid",
                        column: x => x.characterid,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClasses_Character_CharacterID1",
                        column: x => x.CharacterID1,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    CharacterID = table.Column<int>(nullable: false),
                    CharacterID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipment_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Character_CharacterID1",
                        column: x => x.CharacterID1,
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
                    CharacterID = table.Column<int>(nullable: false),
                    CharacterID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foci", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foci_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foci_Character_CharacterID1",
                        column: x => x.CharacterID1,
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
                    characterid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Genders_Character_characterid",
                        column: x => x.characterid,
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
                    characterid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Melee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Melee_Character_characterid",
                        column: x => x.characterid,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    CharacterID = table.Column<int>(nullable: false),
                    CharacterID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skills_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Skills_Character_CharacterID1",
                        column: x => x.CharacterID1,
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
                    CharacterID = table.Column<int>(nullable: false),
                    CharacterID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Weapons_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weapons_Character_CharacterID1",
                        column: x => x.CharacterID1,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armor_CharacterID",
                table: "Armor",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_characterid",
                table: "Backgrounds",
                column: "characterid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Character_ArmorID",
                table: "Character",
                column: "ArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_Character_BackgroundID",
                table: "Character",
                column: "BackgroundID");

            migrationBuilder.CreateIndex(
                name: "IX_Character_GenderID",
                table: "Character",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_characterid",
                table: "CharacterClasses",
                column: "characterid");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_CharacterID1",
                table: "CharacterClasses",
                column: "CharacterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CharacterID",
                table: "Equipment",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CharacterID1",
                table: "Equipment",
                column: "CharacterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Foci_CharacterID",
                table: "Foci",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Foci_CharacterID1",
                table: "Foci",
                column: "CharacterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_characterid",
                table: "Genders",
                column: "characterid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Melee_characterid",
                table: "Melee",
                column: "characterid");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterID",
                table: "Skills",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterID1",
                table: "Skills",
                column: "CharacterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CharacterID",
                table: "Weapons",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CharacterID1",
                table: "Weapons",
                column: "CharacterID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Armor_ArmorID",
                table: "Character",
                column: "ArmorID",
                principalTable: "Armor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Backgrounds_BackgroundID",
                table: "Character",
                column: "BackgroundID",
                principalTable: "Backgrounds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Genders_GenderID",
                table: "Character",
                column: "GenderID",
                principalTable: "Genders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armor_Character_CharacterID",
                table: "Armor");

            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_Character_characterid",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Character_characterid",
                table: "Genders");

            migrationBuilder.DropTable(
                name: "ArmorArchetype");

            migrationBuilder.DropTable(
                name: "BackgroundArchetype");

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

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
