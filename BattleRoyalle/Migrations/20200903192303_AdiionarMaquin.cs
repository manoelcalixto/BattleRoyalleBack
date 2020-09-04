using Microsoft.EntityFrameworkCore.Migrations;

namespace BattleRoyalle.Migrations
{
    public partial class AdiionarMaquin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maquina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMaquina = table.Column<string>(nullable: true),
                    IP = table.Column<string>(nullable: true),
                    AntiVirus = table.Column<string>(nullable: true),
                    FireWall = table.Column<string>(nullable: true),
                    VersaoWindows = table.Column<string>(nullable: true),
                    VersaoNet = table.Column<string>(nullable: true),
                    TamanhoHDDisponivel = table.Column<float>(nullable: false),
                    TamanhoHDTotal = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maquina", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maquina");
        }
    }
}
