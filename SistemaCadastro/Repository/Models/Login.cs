using System.ComponentModel.DataAnnotations;

namespace SistemaCadastro.Repository.Models
{
    public class Login
    {
        public Login()
        {
        }

        [Key] public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string CreateDate { get; set; }
        public string? UpdateDate { get; set; }


    }
}
