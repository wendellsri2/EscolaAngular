using Microsoft.EntityFrameworkCore;
using EscolaAngular_WebApi.Models;

namespace EscolaAngular_WebApi.Data
{
    public class DataContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            _ = modelBuilder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });



            _ = modelBuilder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, "Gregorio de Matos","053322523-11","Rua 24 Brasília","61929581206",new DateTime(2000, 12, 13)),
                    new Professor(2, "Fabiola Cavalcante","033322773-11","Rua 02 Brasília","61999500223",new DateTime(2000, 12, 13)),
                    new Professor(3, "Ronaldo Machado", "032322523-99","Rua 12 Brasília","61999581000",new DateTime(2000, 12, 13)),
                    new Professor(4, "Fernanda Silva","033322523-20","Rua 20 Brasília","61999581215",new DateTime(2000, 12, 13)),
                    new Professor(5, "Janice Pereira","033322523-21","Rua 27 Brasília","61999581139",new DateTime(2000, 12, 13))
                });



            _ = modelBuilder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina(1, "Português", 1),
                    new Disciplina(2, "Matemática", 2),
                    new Disciplina(3, "Historia", 3),
                    new Disciplina(4, "Inglês", 4),
                    new Disciplina(5, "Fisica", 5)
                });



            _ = modelBuilder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1, "Wendell Silva","033322523-13","Rua 14 Brasília","61999581206",new DateTime(1990, 12, 13)),
                    new Aluno(2, "Vanessa Silva Sobrado","033322523-11","Rua 15 Brasília","61999581223",new DateTime(1970, 12, 13)),
                    new Aluno(3, "Jeferson de Oliveira","032322523-14","Rua 18 Brasília","61999581220",new DateTime(1988, 12, 13)),
                    new Aluno(4, "Jessica Andrade","033322523-20","Rua 20 Brasília","61999581215",new DateTime(1990, 12, 13)),
                    new Aluno(5, "Jhonatan Botafogo","033322523-21","Rua 17 Brasília","61999581110",new DateTime(2000, 12, 13)),
                    new Aluno(6, "Ronaldo Gibraltar","033322522-15","Rua 34 Brasília","61999581209",new DateTime(2000, 12, 13)),
                    new Aluno(7, "Gilberto Pereira","033322522-00","Rua 54 Brasília","61999581201",new DateTime(2000, 12, 13))
                });

            _ = modelBuilder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 5 }
                });
        }
    }
}