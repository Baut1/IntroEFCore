using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroEFCore.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPeliculaComentario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Comentarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_MovieId",
                table: "Comentarios",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Peliculas_MovieId",
                table: "Comentarios",
                column: "MovieId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Peliculas_MovieId",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_MovieId",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Comentarios");
        }
    }
}
