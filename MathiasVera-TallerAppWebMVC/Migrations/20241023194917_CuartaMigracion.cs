using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathiasVera_TallerAppWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class CuartaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_EquipoId",
                table: "Jugador");

            migrationBuilder.DropIndex(
                name: "IX_Jugador_EquipoId",
                table: "Jugador");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Jugador");

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador",
                column: "IdEquipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador",
                column: "IdEquipo",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador");

            migrationBuilder.DropIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador");

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Jugador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_EquipoId",
                table: "Jugador",
                column: "EquipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_EquipoId",
                table: "Jugador",
                column: "EquipoId",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
