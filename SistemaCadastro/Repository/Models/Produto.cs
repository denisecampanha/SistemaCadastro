
using System.ComponentModel.DataAnnotations;

namespace SistemaCadastro.Repository.Models
{
    public class Produto
    {
        public Produto()
        {
        }

        [Key] public int Id { get; set; }
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Referencia { get; set; }
        public string Categoria { get; set; }
        public string Grupo { get; set; }
        public string TabPreco { get; set; }
        public string Observacao { get; set; }
        public int Quantidade { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }

    }
}

