using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiaDeConteudo.Migrations
{
    public partial class M002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materiais",
                columns: table => new
                {
                    id_material = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf_usuario = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    areaConhecimento = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    justificativaAnalise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuariocpf_usuario = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiais", x => x.id_material);
                    table.ForeignKey(
                        name: "FK_Materiais_Usuarios_Usuariocpf_usuario",
                        column: x => x.cpf_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "cpf_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    id_avalicao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_material = table.Column<int>(type: "int", nullable: false),
                    cpf_usuario = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    rate = table.Column<int>(type: "int", nullable: false),
                    justificativaAvaliacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuariocpf_usuario = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Materialid_material = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.id_avalicao);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Materiais_Materialid_material",
                        column: x => x.id_material,
                        principalTable: "Materiais",
                        principalColumn: "id_material",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Usuarios_Usuariocpf_usuario",
                        column: x => x.cpf_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "cpf_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_Materialid_material",
                table: "Avaliacoes",
                column: "Materialid_material");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_Usuariocpf_usuario",
                table: "Avaliacoes",
                column: "Usuariocpf_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Materiais_Usuariocpf_usuario",
                table: "Materiais",
                column: "Usuariocpf_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Materiais");
        }
    }
}
