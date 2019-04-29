using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DM_helper.Migrations
{
    public partial class adding_sessions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "session",
                table: "Encounter",
                newName: "SessionID");

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Encounter_SessionID",
                table: "Encounter",
                column: "SessionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Encounter_Session_SessionID",
                table: "Encounter",
                column: "SessionID",
                principalTable: "Session",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encounter_Session_SessionID",
                table: "Encounter");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Encounter_SessionID",
                table: "Encounter");

            migrationBuilder.RenameColumn(
                name: "SessionID",
                table: "Encounter",
                newName: "session");
        }
    }
}
