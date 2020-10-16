using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_LaminacionBLBP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LamblbpDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Planta = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    EstampaTiempo = table.Column<DateTime>(type: "datetime", nullable: false),
                    LaminadorPalanquillaslaminadasUltimahora = table.Column<short>(type: "smallint", nullable: false),
                    LaminadorBarrasperdidasUltimahora = table.Column<float>(type: "real", nullable: false),
                    Plantel = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    Cantidadturnos = table.Column<byte>(type: "tinyint", nullable: false),
                    Fechalaminador = table.Column<DateTime>(type: "date", nullable: false),
                    Modificado = table.Column<DateTime>(type: "datetime", nullable: false),
                    Modificadopor = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LamblbpDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LamblbpDetails");
        }
    }
}
