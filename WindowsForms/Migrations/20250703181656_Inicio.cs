using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WindowsForms.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    _id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    portada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calificacion = table.Column<double>(type: "double", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Peliculas_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Estados Unidos" },
                    { 2, false, "Reino Unido" },
                    { 3, false, "Alemania" },
                    { 4, false, "Francia" },
                    { 5, false, "Italia" },
                    { 6, false, "España" },
                    { 7, false, "Japón" },
                    { 8, false, "Canadá" },
                    { 9, false, "Australia" },
                    { 10, false, "México" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "id", "Eliminado", "PaisId", "_id", "calificacion", "duracion", "portada", "titulo" },
                values: new object[,]
                {
                    { 1, false, 6, "1", 9.1999999999999993, 175, "https://ejemplo.com/portadas/el_padrino.jpg", "El Padrino" },
                    { 2, false, 8, "2", 8.9000000000000004, 154, "https://ejemplo.com/portadas/pulp_fiction.jpg", "Pulp Fiction" },
                    { 3, false, 6, "3", 8.8000000000000007, 142, "https://ejemplo.com/portadas/forrest_gump.jpg", "Forrest Gump" },
                    { 4, false, 2, "4", 8.9000000000000004, 195, "https://ejemplo.com/portadas/schindler.jpg", "La lista de Schindler" },
                    { 5, false, 6, "5", 8.9000000000000004, 201, "https://ejemplo.com/portadas/lotr_rey.jpg", "El Señor de los Anillos: El Retorno del Rey" },
                    { 6, false, 6, "6", 8.8000000000000007, 148, "https://ejemplo.com/portadas/inception.jpg", "Inception" },
                    { 7, false, 8, "7", 8.8000000000000007, 139, "https://ejemplo.com/portadas/fight_club.jpg", "Fight Club" },
                    { 8, false, 8, "8", 8.5999999999999996, 169, "https://ejemplo.com/portadas/interstellar.jpg", "Interstellar" },
                    { 9, false, 2, "9", 8.5, 155, "https://ejemplo.com/portadas/gladiator.jpg", "Gladiator" },
                    { 10, false, 2, "10", 8.6999999999999993, 136, "https://ejemplo.com/portadas/matrix.jpg", "Matrix" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_PaisId",
                table: "Peliculas",
                column: "PaisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
