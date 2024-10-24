using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathiasVera_TallerAppWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Ciudad",
                table: "Estadio",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Ciudad",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Ciudad",
                table: "Estadio",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ciudad",
                table: "Equipo",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
