using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetWebApi.Migrations
{
    /// <inheritdoc />
    public partial class BuildBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comorbidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condicao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrequenciaCardiaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrequenciaRespiratoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PressaoArterialSistemica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hematocrito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leucocitos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.AnimalId);
                });

            migrationBuilder.CreateTable(
                name: "Remedios",
                columns: table => new
                {
                    RemedioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrincipioAtivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MecanismoAcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViaAdministracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EfeitoAdverso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodeAumentarFrequenciaCardiaca = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirFrequenciaCardiaca = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarFrequenciaRespiratoria = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirFrequenciaRespiratoria = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarPressaoArterial = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirPressaoArterial = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarHematocritos = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirHematocritos = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarLeucocitos = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirLeucocitos = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remedios", x => x.RemedioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Remedios");
        }
    }
}
