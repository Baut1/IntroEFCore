using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroEFCore.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPeliculasActores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Peliculas_MovieId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Generos_GenresId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Peliculas_MoviesId",
                table: "GeneroPelicula");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Peliculas",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Peliculas",
                newName: "FechaEstreno");

            migrationBuilder.RenameColumn(
                name: "AtCinemas",
                table: "Peliculas",
                newName: "EnCines");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Generos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "GeneroPelicula",
                newName: "PeliculasId");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "GeneroPelicula",
                newName: "GenerosId");

            migrationBuilder.RenameIndex(
                name: "IX_GeneroPelicula_MoviesId",
                table: "GeneroPelicula",
                newName: "IX_GeneroPelicula_PeliculasId");

            migrationBuilder.RenameColumn(
                name: "Recommend",
                table: "Comentarios",
                newName: "Recomendar");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Comentarios",
                newName: "PeliculaId");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Comentarios",
                newName: "Contenido");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_MovieId",
                table: "Comentarios",
                newName: "IX_Comentarios_PeliculaId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Actores",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Fortune",
                table: "Actores",
                newName: "Fortuna");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Actores",
                newName: "FechaNacimiento");

            migrationBuilder.CreateTable(
                name: "PeliculasActores",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Personaje = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculasActores", x => new { x.ActorId, x.PeliculaId });
                    table.ForeignKey(
                        name: "FK_PeliculasActores_Actores_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculasActores_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasActores_PeliculaId",
                table: "PeliculasActores",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Peliculas_PeliculaId",
                table: "Comentarios",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Generos_GenerosId",
                table: "GeneroPelicula",
                column: "GenerosId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Peliculas_PeliculasId",
                table: "GeneroPelicula",
                column: "PeliculasId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Peliculas_PeliculaId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Generos_GenerosId",
                table: "GeneroPelicula");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroPelicula_Peliculas_PeliculasId",
                table: "GeneroPelicula");

            migrationBuilder.DropTable(
                name: "PeliculasActores");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Peliculas",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "FechaEstreno",
                table: "Peliculas",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "EnCines",
                table: "Peliculas",
                newName: "AtCinemas");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Generos",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PeliculasId",
                table: "GeneroPelicula",
                newName: "MoviesId");

            migrationBuilder.RenameColumn(
                name: "GenerosId",
                table: "GeneroPelicula",
                newName: "GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_GeneroPelicula_PeliculasId",
                table: "GeneroPelicula",
                newName: "IX_GeneroPelicula_MoviesId");

            migrationBuilder.RenameColumn(
                name: "Recomendar",
                table: "Comentarios",
                newName: "Recommend");

            migrationBuilder.RenameColumn(
                name: "PeliculaId",
                table: "Comentarios",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Contenido",
                table: "Comentarios",
                newName: "Content");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_PeliculaId",
                table: "Comentarios",
                newName: "IX_Comentarios_MovieId");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Actores",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Fortuna",
                table: "Actores",
                newName: "Fortune");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Actores",
                newName: "BirthDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Peliculas_MovieId",
                table: "Comentarios",
                column: "MovieId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Generos_GenresId",
                table: "GeneroPelicula",
                column: "GenresId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroPelicula_Peliculas_MoviesId",
                table: "GeneroPelicula",
                column: "MoviesId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
