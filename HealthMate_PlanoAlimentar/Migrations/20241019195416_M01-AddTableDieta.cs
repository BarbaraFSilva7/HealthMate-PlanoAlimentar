using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate_PlanoAlimentar.Migrations
{
    /// <inheritdoc />
    public partial class M01AddTableDieta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanoAlimentar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Altura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Alergia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Restricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CondSaude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsoMedicamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoAlimentar", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanoAlimentar");
        }
    }
}
