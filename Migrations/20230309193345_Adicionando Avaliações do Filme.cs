using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesFilmes.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoAvaliaçõesdoFilme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvalicaoCritica",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvalicaoPublico",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvalicaoCritica",
                table: "Filme");

            migrationBuilder.DropColumn(
                name: "AvalicaoPublico",
                table: "Filme");
        }
    }
}
