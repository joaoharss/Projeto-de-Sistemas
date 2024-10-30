﻿namespace Cadastro_Mvc.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
