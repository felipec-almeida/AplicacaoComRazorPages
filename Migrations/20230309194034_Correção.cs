using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesFilmes.Migrations
{
    /// <inheritdoc />
    public partial class Correção : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvalicaoPublico",
                table: "Filme",
                newName: "AvaliacaoPublico");

            migrationBuilder.RenameColumn(
                name: "AvalicaoCritica",
                table: "Filme",
                newName: "AvaliacaoCritica");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvaliacaoPublico",
                table: "Filme",
                newName: "AvalicaoPublico");

            migrationBuilder.RenameColumn(
                name: "AvaliacaoCritica",
                table: "Filme",
                newName: "AvalicaoCritica");
        }
    }
}
