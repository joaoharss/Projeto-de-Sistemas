namespace Cadastro_Mvc.Model
{
    public class Endereco
    {
        //Logradouro, número, estado (UF), cidade e Bairro)
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
    }
}
