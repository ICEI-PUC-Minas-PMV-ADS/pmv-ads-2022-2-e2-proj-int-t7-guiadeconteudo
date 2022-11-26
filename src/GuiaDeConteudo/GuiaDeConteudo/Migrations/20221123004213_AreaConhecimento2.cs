using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiaDeConteudo.Migrations
{
    public partial class AreaConhecimento2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiais_AreaConhecimento_Area_id",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "areaConhecimento",
                table: "Materiais");

            migrationBuilder.AlterColumn<int>(
                name: "Area_id",
                table: "Materiais",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Materiais_AreaConhecimento_Area_id",
                table: "Materiais",
                column: "Area_id",
                principalTable: "AreaConhecimento",
                principalColumn: "Area_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiais_AreaConhecimento_Area_id",
                table: "Materiais");

            migrationBuilder.AlterColumn<int>(
                name: "Area_id",
                table: "Materiais",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "areaConhecimento",
                table: "Materiais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Materiais_AreaConhecimento_Area_id",
                table: "Materiais",
                column: "Area_id",
                principalTable: "AreaConhecimento",
                principalColumn: "Area_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
