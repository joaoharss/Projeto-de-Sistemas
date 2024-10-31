
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Cadastro_Mvc.Model
{
    public class Pessoa 
    {
        [Required]
        [Key]
        public Guid Id { get; private set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public virtual IEnumerable<Endereco> Enderecos { get; set; } = new List<Endereco>();
    }
}
