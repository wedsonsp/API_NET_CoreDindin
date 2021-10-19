using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiDindin.Migrations
{
    public partial class Atualizacao_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DescricaoAula",
                table: "Aulas",
                type: "varchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Aulas",
                keyColumn: "AulaId",
                keyValue: 1,
                columns: new[] { "DescricaoAula", "TituloAula" },
                values: new object[] { "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", "Aula 1" });

            migrationBuilder.UpdateData(
                table: "Aulas",
                keyColumn: "AulaId",
                keyValue: 2,
                columns: new[] { "DescricaoAula", "TituloAula" },
                values: new object[] { "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", "Aula 2" });

            migrationBuilder.UpdateData(
                table: "Aulas",
                keyColumn: "AulaId",
                keyValue: 3,
                columns: new[] { "DescricaoAula", "TituloAula" },
                values: new object[] { "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", "Aula 3" });

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 1,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", "Investimento para Iniciantes" });

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 2,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", "Poupando e Rendendo" });

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 3,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", "Independência Financeira" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DescricaoAula",
                table: "Aulas",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldMaxLength: 300,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Aulas",
                keyColumn: "AulaId",
                keyValue: 1,
                columns: new[] { "DescricaoAula", "TituloAula" },
                values: new object[] { "Descrição Aula1", "Aula1" });

            migrationBuilder.UpdateData(
                table: "Aulas",
                keyColumn: "AulaId",
                keyValue: 2,
                columns: new[] { "DescricaoAula", "TituloAula" },
                values: new object[] { "Descrição Aula2", "Aula2" });

            migrationBuilder.UpdateData(
                table: "Aulas",
                keyColumn: "AulaId",
                keyValue: 3,
                columns: new[] { "DescricaoAula", "TituloAula" },
                values: new object[] { "Descrição Aula3", "Aula3" });

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 1,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "Curso teste1", "Titulo 1" });

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 2,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "Curso teste2", "Titulo 2" });

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 3,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "Curso teste3", "Titulo 3" });
        }
    }
}
