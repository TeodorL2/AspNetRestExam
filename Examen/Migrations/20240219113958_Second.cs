using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfesorMaterii");

            migrationBuilder.DropTable(
                name: "Materii");

            migrationBuilder.DropTable(
                name: "Profesori");

            migrationBuilder.CreateTable(
                name: "Actori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeRegizor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLansarii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmActori",
                columns: table => new
                {
                    IdFilm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdActor = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmActori", x => new { x.IdFilm, x.IdActor });
                    table.ForeignKey(
                        name: "FK_FilmActori_Actori_IdActor",
                        column: x => x.IdActor,
                        principalTable: "Actori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActori_Filme_IdFilm",
                        column: x => x.IdFilm,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmActori_IdActor",
                table: "FilmActori",
                column: "IdActor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmActori");

            migrationBuilder.DropTable(
                name: "Actori");

            migrationBuilder.DropTable(
                name: "Filme");

            migrationBuilder.CreateTable(
                name: "Materii",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrOreSapt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipProfesor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfesorMaterii",
                columns: table => new
                {
                    IdProfesor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMaterie = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesorMaterii", x => new { x.IdProfesor, x.IdMaterie });
                    table.ForeignKey(
                        name: "FK_ProfesorMaterii_Materii_IdMaterie",
                        column: x => x.IdMaterie,
                        principalTable: "Materii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesorMaterii_Profesori_IdProfesor",
                        column: x => x.IdProfesor,
                        principalTable: "Profesori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfesorMaterii_IdMaterie",
                table: "ProfesorMaterii",
                column: "IdMaterie");
        }
    }
}
