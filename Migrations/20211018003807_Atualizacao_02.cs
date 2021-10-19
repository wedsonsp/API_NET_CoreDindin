using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiDindin.Migrations
{
    public partial class Atualizacao_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.AddColumn<string>(
                name: "Professor",
                table: "Cursos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 1,
                column: "Professor",
                value: "Marcos Santos");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 2,
                column: "Professor",
                value: "Luiz Carlos");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 3,
                column: "Professor",
                value: "Regina Sanderberg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Professor",
                table: "Cursos");

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.ProfessorId);
                    table.ForeignKey(
                        name: "FK_Professores_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "ProfessorId", "CursoId", "Nome" },
                values: new object[] { 1, 1, "Paulo Sergio" });

            migrationBuilder.CreateIndex(
                name: "IX_Professores_CursoId",
                table: "Professores",
                column: "CursoId",
                unique: true);
        }
    }
}
