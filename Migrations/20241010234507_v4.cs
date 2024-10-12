using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practica4.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personajes_multimedias_multimediaID",
                table: "personajes");

            migrationBuilder.RenameColumn(
                name: "multimediaID",
                table: "personajes",
                newName: "multimediaid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "personajes",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_personajes_multimediaID",
                table: "personajes",
                newName: "IX_personajes_multimediaid");

            migrationBuilder.RenameColumn(
                name: "Idioma",
                table: "multimedias",
                newName: "idioma");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "multimedias",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "multimediaid",
                table: "personajes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "personajes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "tipo",
                table: "multimedias",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "multimedias",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_personajes_multimedias_multimediaid",
                table: "personajes",
                column: "multimediaid",
                principalTable: "multimedias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personajes_multimedias_multimediaid",
                table: "personajes");

            migrationBuilder.RenameColumn(
                name: "multimediaid",
                table: "personajes",
                newName: "multimediaID");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "personajes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_personajes_multimediaid",
                table: "personajes",
                newName: "IX_personajes_multimediaID");

            migrationBuilder.RenameColumn(
                name: "idioma",
                table: "multimedias",
                newName: "Idioma");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "multimedias",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "multimediaID",
                table: "personajes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "personajes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "multimedias",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "multimedias",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_personajes_multimedias_multimediaID",
                table: "personajes",
                column: "multimediaID",
                principalTable: "multimedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
