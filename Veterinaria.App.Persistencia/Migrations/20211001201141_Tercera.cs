using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.App.Persistencia.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cedula = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jornada_Laboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarjeta_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veterinario_Jornada_Laboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "mascotas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueñoID = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perro_Comida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mascotas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_mascotas_personas_DueñoID",
                        column: x => x.DueñoID,
                        principalTable: "personas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "citas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuxiliarID = table.Column<int>(type: "int", nullable: true),
                    VeterinariaID = table.Column<int>(type: "int", nullable: true),
                    MascotaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_citas_mascotas_MascotaID",
                        column: x => x.MascotaID,
                        principalTable: "mascotas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_citas_personas_AuxiliarID",
                        column: x => x.AuxiliarID,
                        principalTable: "personas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_citas_personas_VeterinariaID",
                        column: x => x.VeterinariaID,
                        principalTable: "personas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "diagnosticos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoriaClinical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anotacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosticos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_diagnosticos_citas_CitaID",
                        column: x => x.CitaID,
                        principalTable: "citas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_citas_AuxiliarID",
                table: "citas",
                column: "AuxiliarID");

            migrationBuilder.CreateIndex(
                name: "IX_citas_MascotaID",
                table: "citas",
                column: "MascotaID");

            migrationBuilder.CreateIndex(
                name: "IX_citas_VeterinariaID",
                table: "citas",
                column: "VeterinariaID");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosticos_CitaID",
                table: "diagnosticos",
                column: "CitaID");

            migrationBuilder.CreateIndex(
                name: "IX_mascotas_DueñoID",
                table: "mascotas",
                column: "DueñoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diagnosticos");

            migrationBuilder.DropTable(
                name: "citas");

            migrationBuilder.DropTable(
                name: "mascotas");

            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
