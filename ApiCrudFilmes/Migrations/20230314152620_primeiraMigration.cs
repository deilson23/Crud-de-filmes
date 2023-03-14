using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCrudFilmes.Migrations
{
    /// <inheritdoc />
    public partial class primeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Idioma = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Duracao = table.Column<int>(type: "int", nullable: false),
                    Avaliacao = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
