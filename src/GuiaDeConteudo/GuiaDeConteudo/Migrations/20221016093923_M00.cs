using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiaDeConteudo.Migrations
{
    public partial class M00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf_usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    grauEscolaridade = table.Column<int>(type: "int", nullable: false),
                    formacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
