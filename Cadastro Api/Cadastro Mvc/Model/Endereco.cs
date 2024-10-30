using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Cadastro_Mvc.Model
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }

        public virtual int IdPessoa { get; set; }
        [ForeignKey("IdPessoa")]
        public virtual Pessoa? Pessoa { get; set; }
    }
}
