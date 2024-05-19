

namespace SistemaCadastro.Models
{
    public class Result(bool sucesso, string? mensagemDb)
    {
        public bool Success { get; set; } = sucesso;
        public string? Message { get; set; } = mensagemDb;

    }
}



