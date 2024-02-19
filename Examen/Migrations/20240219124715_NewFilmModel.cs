using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Migrations
{
    /// <inheritdoc />
    public partial class NewFilmModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataLansarii",
                table: "Filme");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataLansarii",
                table: "Filme",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
