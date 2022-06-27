using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoBlazorServer.Data.Migrations
{
    public partial class migracion27082022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogo_Aplicaciones",
                columns: table => new
                {
                    IdAplicacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosicionGrupo = table.Column<string>(nullable: true),
                    Posicion = table.Column<string>(nullable: true),
                    SubPosicion = table.Column<string>(nullable: true),
                    DesignacionSkfGlobal = table.Column<string>(nullable: true),
                    DesignacionSKF = table.Column<string>(nullable: true),
                    Observacion = table.Column<string>(nullable: true),
                    IdVehiculo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo_Aplicaciones", x => x.IdAplicacion);
                });

            migrationBuilder.CreateTable(
                name: "Catalogo_Designaciones",
                columns: table => new
                {
                    IdDesignacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignaionSkfGlobal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo_Designaciones", x => x.IdDesignacion);
                });

            migrationBuilder.CreateTable(
                name: "Catalogo_MarcaVehiculo",
                columns: table => new
                {
                    IdMarca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo_MarcaVehiculo", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "Catalogo_ModeloVehiculo",
                columns: table => new
                {
                    IdModelo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo_ModeloVehiculo", x => x.IdModelo);
                });

            migrationBuilder.CreateTable(
                name: "Catalogo_Segmento",
                columns: table => new
                {
                    IdSegmento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Segmento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo_Segmento", x => x.IdSegmento);
                });

            migrationBuilder.CreateTable(
                name: "Catalogo_Vehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(nullable: true),
                    FechaInicial = table.Column<DateTime>(nullable: false),
                    FechaFinal = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo_Vehiculos", x => x.IdVehiculo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogo_Aplicaciones");

            migrationBuilder.DropTable(
                name: "Catalogo_Designaciones");

            migrationBuilder.DropTable(
                name: "Catalogo_MarcaVehiculo");

            migrationBuilder.DropTable(
                name: "Catalogo_ModeloVehiculo");

            migrationBuilder.DropTable(
                name: "Catalogo_Segmento");

            migrationBuilder.DropTable(
                name: "Catalogo_Vehiculos");
        }
    }
}
