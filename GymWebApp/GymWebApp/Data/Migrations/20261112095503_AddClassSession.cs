using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddClassSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FitnessClassId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSessions_FitnessClasses_FitnessClassId",
                        column: x => x.FitnessClassId,
                        principalTable: "FitnessClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSessions_FitnessClassId",
                table: "ClassSessions",
                column: "FitnessClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSessions");
        }
    }
}
