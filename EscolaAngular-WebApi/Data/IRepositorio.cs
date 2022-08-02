using EscolaAngular_WebApi.Models;

namespace EscolaAngular_WebApi.Data
{
    public interface IRepositorio
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ALUNO
        Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor);
        Task<Aluno[]> GetAlunosAsyncByDisciplinaId(int disciplinaId, bool includeDisciplina);
        Task<Aluno> GetAlunoAsyncById(int alunoId, bool includeProfessor);

        //PROFESSOR
        Task<Professor[]> GetAllProfessoresAsync(bool includeAluno);
        Task<Professor> GetProfessorAsyncById(int professorId, bool includeAluno);
        Task<Professor[]> GetProfessoresAsyncByAlunoId(int alunoId, bool includeDisciplina);
        Task<Aluno[]?> GetAlunoAsyncById();
        Task<Aluno[]?> GetAlunoAsyncById(bool v);
    }
}
