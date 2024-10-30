
namespace Cadastro_Mvc.Model
{
    public class Pessoa 
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual IEnumerable<Endereco> Enderecos { get; set; } = new List<Endereco>();
    }
}
