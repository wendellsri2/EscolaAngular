namespace EscolaAngular_WebApi.Models
{

    public class Aluno
    {
        public Aluno() { }

        public Aluno(int? id, string name, string endereco, string? cpf, string? telefone, DateTime? dtNascimento)
        {
            Id = id;
            Name = name;
            Endereco = endereco;
            Telefone = telefone;
            DtNascimento = dtNascimento;
        }

        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public DateTime? DtNascimento { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }



    }
}