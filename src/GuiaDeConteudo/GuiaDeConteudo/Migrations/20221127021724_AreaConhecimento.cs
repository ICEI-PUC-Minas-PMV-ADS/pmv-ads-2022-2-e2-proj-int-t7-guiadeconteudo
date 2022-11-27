using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiaDeConteudo.Migrations
{
    public partial class AreaConhecimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "areaConhecimento",
                table: "Materiais",
                newName: "AreaConhecimentoID");

            migrationBuilder.CreateTable(
                name: "AreaConhecimento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaConhecimento", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materiais_AreaConhecimentoID",
                table: "Materiais",
                column: "AreaConhecimentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiais_AreaConhecimento_AreaConhecimentoID",
                table: "Materiais",
                column: "AreaConhecimentoID",
                principalTable: "AreaConhecimento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiais_AreaConhecimento_AreaConhecimentoID",
                table: "Materiais");

            migrationBuilder.DropTable(
                name: "AreaConhecimento");

            migrationBuilder.DropIndex(
                name: "IX_Materiais_AreaConhecimentoID",
                table: "Materiais");

  

            migrationBuilder.RenameColumn(
                name: "AreaConhecimentoID",
                table: "Materiais",
                newName: "areaConhecimento");
        }
    }
}
