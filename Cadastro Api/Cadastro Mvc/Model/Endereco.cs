using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Cadastro_Mvc.Model
{
    public class Endereco
    {
        [Required]
        public Guid Id { get; private set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        [MaxLength(2)]
        public string UF { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public virtual Guid IdPessoa { get; set; }
        [ForeignKey("IdPessoa")]
        public virtual Pessoa? Pessoa { get; set; }
    }
}
