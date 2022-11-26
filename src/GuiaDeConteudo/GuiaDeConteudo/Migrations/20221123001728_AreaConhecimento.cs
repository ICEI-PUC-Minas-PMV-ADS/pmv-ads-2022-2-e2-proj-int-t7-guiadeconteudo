using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiaDeConteudo.Migrations
{
    public partial class AreaConhecimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Area_id",
                table: "Materiais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AreaConhecimento",
                columns: table => new
                {
                    Area_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area_nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaConhecimento", x => x.Area_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materiais_Area_id",
                table: "Materiais",
                column: "Area_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiais_AreaConhecimento_Area_id",
                table: "Materiais",
                column: "Area_id",
                principalTable: "AreaConhecimento",
                principalColumn: "Area_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiais_AreaConhecimento_Area_id",
                table: "Materiais");

            migrationBuilder.DropTable(
                name: "AreaConhecimento");

            migrationBuilder.DropIndex(
                name: "IX_Materiais_Area_id",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "Area_id",
                table: "Materiais");
        }
    }
}
