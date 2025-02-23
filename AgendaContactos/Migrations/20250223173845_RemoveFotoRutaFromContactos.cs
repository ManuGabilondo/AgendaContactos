using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContactos.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFotoRutaFromContactos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoRuta",
                table: "Contactos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoRuta",
                table: "Contactos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
