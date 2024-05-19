

namespace SistemaCadastro.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

    }
}
