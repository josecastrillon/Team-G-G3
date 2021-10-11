using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.App.Persistencia.Migrations
{
    public partial class modd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diaSemana = table.Column<int>(type: "int", nullable: false),
                    horaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorariosVeterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    horarioId = table.Column<int>(type: "int", nullable: true),
                    veterinarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosVeterinarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorariosVeterinarios_Horarios_horarioId",
                        column: x => x.horarioId,
                        principalTable: "Horarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HorariosVeterinarios_Personas_veterinarioId",
                        column: x => x.veterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorariosVeterinarios_horarioId",
                table: "HorariosVeterinarios",
                column: "horarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HorariosVeterinarios_veterinarioId",
                table: "HorariosVeterinarios",
                column: "veterinarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorariosVeterinarios");

            migrationBuilder.DropTable(
                name: "Horarios");
        }
    }
}
