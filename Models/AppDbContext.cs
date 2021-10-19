using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDindin.Models
{
    //Mapeamento entre a as entidades e as tabelas do banco.
    public class AppDbContext : DbContext
    {
        //AppDbContext vai herdar de DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Mapeamento das entidades com as tabelas
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aula> Aulas { get; set; }


        //Inclusão de dados Iniciais nas tabelas do banco
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Curso>()
                .Property(p => p.Titulo)
                    .HasMaxLength(50);

            modelBuilder.Entity<Curso>()
                .Property(p => p.UploadCapa)
                    .HasMaxLength(80);

            modelBuilder.Entity<Curso>()
              .Property(p => p.Professor)
                  .HasMaxLength(50);

            modelBuilder.Entity<Curso>()
                .Property(p => p.Descricao)
                    .HasMaxLength(300);

            modelBuilder.Entity<Curso>()
                .HasData(

                    
                    new Curso { CursoId = 1, Titulo = "Investimento para Iniciantes", UploadCapa = "Capa teste1", Professor = "Marcos Santos",  Descricao = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. " },
                    new Curso { CursoId = 2, Titulo = "Poupando e Rendendo", UploadCapa = "Capa teste2", Professor = "Luiz Carlos",   Descricao = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. " },
                    new Curso { CursoId = 3, Titulo = "Independência Financeira", UploadCapa = "Capa teste3", Professor = "Regina Sanderberg",   Descricao = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. " }
                ); ;

            modelBuilder.Entity<Aula>()
           .Property(p => p.TituloAula)
               .HasMaxLength(80);

            modelBuilder.Entity<Aula>()
           .Property(p => p.LinkAula)
               .HasMaxLength(80);

            modelBuilder.Entity<Aula>()
           .Property(p => p.DescricaoAula)
               .HasMaxLength(300);

            modelBuilder.Entity<Aula>()
    .HasData(

        new Aula { AulaId = 1, TituloAula = "Aula 1", LinkAula = "www.aula.com", DescricaoAula = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ",
                   CursoId = 1},
        new Aula { AulaId = 2, TituloAula = "Aula 2", LinkAula = "www.aula.com", DescricaoAula = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", 
                   CursoId = 2 },
        new Aula { AulaId = 3, TituloAula = "Aula 3", LinkAula = "www.aula.com", DescricaoAula = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. ", 
                   CursoId = 3 }
    );





        }
    }





}
