using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaceAcrossAmerica.Migrations
{
    /// <inheritdoc />
    public partial class AddRaceParticipantJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RaceParticipants",
                columns: table => new
                {
                    RaceParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceParticipants", x => x.RaceParticipantId);
                    table.ForeignKey(
                        name: "FK_RaceParticipants_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceParticipants_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaceParticipants_RaceId",
                table: "RaceParticipants",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceParticipants_StudentId",
                table: "RaceParticipants",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaceParticipants");
        }
    }
}
