using Microsoft.EntityFrameworkCore.Migrations;

namespace LocacaoFilme.Infrastructure.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('O jogo da imitação', 12, 0)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('A teoria de tudo', 10, 0)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('Piratas do Caribe', 14, 0)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('Não olhe para cima', 18, 1)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('Vingança e Castigo', 18, 0)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('O Esquadrão Suicida', 16, 0)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('Eternos', 14, 1)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('Shang-Chi e a Lenda dos Dez Anéis', 10, 1)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('Homem-Aranha: Sem Volta para Casa', 12, 1)");
            migrationBuilder.Sql("Insert into Filmes (Titulo, ClassificacaoIndicativa, Lancamento)" +
                                 " Values ('Uma mente brilhante', 10, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Filmes");
        }
    }
}
