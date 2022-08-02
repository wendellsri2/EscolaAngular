namespace EscolaAngular_WebApi.Models
{
    public class Disciplina
    {
        internal readonly object AlunoDisciplina;

        public Disciplina() { }
        public Disciplina(int id, string name, int professorId)
        {
            Id = id;
            Name = name;
            ProfessorId = professorId;

        }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int ProfessorId { get; set; }
        public Professor? Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}