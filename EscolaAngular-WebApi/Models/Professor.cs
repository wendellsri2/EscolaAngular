namespace EscolaAngular_WebApi.Models
{
    public class Professor
    {
        public Professor() { }
        public Professor(int? id,
                         string? name,
                         string? cpf,
                         string? endereco,
                         string? telefone,
                         DateTime? dtNascimento)
        {
            Id = id;
            Nome = name;
            Endereco = endereco;
            Telefone = telefone;
            DtNascimento = dtNascimento;
        }
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public IEnumerable<Disciplina> Disciplina { get; set; }
        public string? CPF { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public DateTime? DtNascimento { get; set; }

    }
}