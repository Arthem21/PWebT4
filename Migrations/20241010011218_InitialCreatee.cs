using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practica4.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "multimedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(type: "TEXT", nullable: false),
                    pais = table.Column<string>(type: "TEXT", nullable: true),
                    Idioma = table.Column<string>(type: "TEXT", nullable: true),
                    foto = table.Column<string>(type: "TEXT", nullable: true),
                    resumen = table.Column<string>(type: "TEXT", nullable: true),
                    tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multimedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(type: "TEXT", nullable: false),
                    apodo = table.Column<string>(type: "TEXT", nullable: true),
                    raza = table.Column<string>(type: "TEXT", nullable: true),
                    foto = table.Column<string>(type: "TEXT", nullable: true),
                    edad = table.Column<int>(type: "INTEGER", nullable: true),
                    habilidad = table.Column<string>(type: "TEXT", nullable: true),
                    multimediaID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personajes_multimedias_multimediaID",
                        column: x => x.multimediaID,
                        principalTable: "multimedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personajes_multimediaID",
                table: "personajes",
                column: "multimediaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personajes");

            migrationBuilder.DropTable(
                name: "multimedias");
        }
    }
}
