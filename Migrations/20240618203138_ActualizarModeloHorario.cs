using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubDeportivoLeones.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarModeloHorario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraFin",
                table: "Horarios");

            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "Horarios");

            migrationBuilder.AddColumn<int>(
                name: "Hora",
                table: "Horarios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Horarios");

            migrationBuilder.AddColumn<string>(
                name: "HoraFin",
                table: "Horarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HoraInicio",
                table: "Horarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
