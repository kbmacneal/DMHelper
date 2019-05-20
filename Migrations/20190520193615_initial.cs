using Microsoft.EntityFrameworkCore.Migrations;

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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    faction = table.Column<string>(nullable: true),
                    homeworld = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    currenthp = table.Column<int>(nullable: false),
                    maxhp = table.Column<int>(nullable: false),
                    currentsystemstrain = table.Column<int>(nullable: false),
                    maxsystemstrain = table.Column<int>(nullable: false),
                    permanentstrain = table.Column<int>(nullable: false),
                    currentxp = table.Column<int>(nullable: false),
                    xptilnextlevel = table.Column<int>(nullable: false),
                    baseac = table.Column<int>(nullable: false),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                name: "PsionicSchools",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsionicSchools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SkillsArchetype",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    ac = table.Column<int>(nullable: false),
                    cost = table.Column<long>(nullable: false),
                    encumbrance = table.Column<long>(nullable: false),
                    techlevel = table.Column<long>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true),
                    ArchetypeID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Armor_ArmorArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "ArmorArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: false),
                    ArchetypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Backgrounds_BackgroundArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "BackgroundArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: false),
                    ArchetypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterClasses_CharacterClasses_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "CharacterClasses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    cost = table.Column<string>(nullable: true),
                    encumbrance = table.Column<string>(nullable: true),
                    techlevel = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: true),
                    ArchetypeID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "EquipmentArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true),
                    ArchetypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foci", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foci_FociArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "FociArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    CharacterID = table.Column<int>(nullable: false),
                    ArchetypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Genders_GenderArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "GenderArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    damage = table.Column<string>(nullable: true),
                    shockdamage = table.Column<string>(nullable: true),
                    attribute = table.Column<string>(nullable: true),
                    cost = table.Column<long>(nullable: false),
                    encumbrance = table.Column<long>(nullable: false),
                    techlevel = table.Column<long>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true),
                    ArchetypeID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Melee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Melee_MeleeArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "MeleeArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Melee_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PsionicSkillArchetypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Encounter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    SessionID = table.Column<int>(nullable: false),
                    initiative = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encounter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Encounter_Session_SessionID",
                        column: x => x.SessionID,
                        principalTable: "Session",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    specialist = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true),
                    ArchetypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skills_SkillsArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "SkillsArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    damage = table.Column<string>(nullable: true),
                    range = table.Column<string>(nullable: true),
                    cost = table.Column<string>(nullable: true),
                    magazine = table.Column<string>(nullable: true),
                    encumbrance = table.Column<string>(nullable: true),
                    attribute = table.Column<string>(nullable: true),
                    techlevel = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: true),
                    ArchetypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Weapons_WeaponArchetype_ArchetypeID",
                        column: x => x.ArchetypeID,
                        principalTable: "WeaponArchetype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weapons_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PsionicAbilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    level = table.Column<int>(nullable: false),
                    PsionicSchoolID = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: false),
                    ArchetypeID = table.Column<int>(nullable: false),
                    isactive = table.Column<bool>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CharacterEncounter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EncounterID = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEncounter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterEncounter_Character_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Character",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterEncounter_Encounter_EncounterID",
                        column: x => x.EncounterID,
                        principalTable: "Encounter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armor_ArchetypeID",
                table: "Armor",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Armor_CharacterID",
                table: "Armor",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_ArchetypeID",
                table: "Backgrounds",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_CharacterID",
                table: "Backgrounds",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_ArchetypeID",
                table: "CharacterClasses",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_CharacterID",
                table: "CharacterClasses",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEncounter_CharacterID",
                table: "CharacterEncounter",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEncounter_EncounterID",
                table: "CharacterEncounter",
                column: "EncounterID");

            migrationBuilder.CreateIndex(
                name: "IX_Encounter_SessionID",
                table: "Encounter",
                column: "SessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ArchetypeID",
                table: "Equipment",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CharacterID",
                table: "Equipment",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Foci_ArchetypeID",
                table: "Foci",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Foci_CharacterID",
                table: "Foci",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_ArchetypeID",
                table: "Genders",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_CharacterID",
                table: "Genders",
                column: "CharacterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Melee_ArchetypeID",
                table: "Melee",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Melee_CharacterID",
                table: "Melee",
                column: "CharacterID");

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

            migrationBuilder.CreateIndex(
                name: "IX_PsionicSkillArchetypes_PsionicSchoolID",
                table: "PsionicSkillArchetypes",
                column: "PsionicSchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ArchetypeID",
                table: "Skills",
                column: "ArchetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterID",
                table: "Skills",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_ArchetypeID",
                table: "Weapons",
                column: "ArchetypeID");

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
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "CharacterClassArchetype");

            migrationBuilder.DropTable(
                name: "CharacterClasses");

            migrationBuilder.DropTable(
                name: "CharacterEncounter");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Foci");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Melee");

            migrationBuilder.DropTable(
                name: "PsionicAbilities");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "ArmorArchetype");

            migrationBuilder.DropTable(
                name: "BackgroundArchetype");

            migrationBuilder.DropTable(
                name: "Encounter");

            migrationBuilder.DropTable(
                name: "EquipmentArchetype");

            migrationBuilder.DropTable(
                name: "FociArchetype");

            migrationBuilder.DropTable(
                name: "GenderArchetype");

            migrationBuilder.DropTable(
                name: "MeleeArchetype");

            migrationBuilder.DropTable(
                name: "PsionicSkillArchetypes");

            migrationBuilder.DropTable(
                name: "SkillsArchetype");

            migrationBuilder.DropTable(
                name: "WeaponArchetype");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "PsionicSchools");
        }
    }
}
