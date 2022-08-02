namespace EscolaAngular_WebApi.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }
        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }
        public Aluno? Aluno { get; set; }
        public Disciplina? Disciplina { get; set; }
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
    }
}