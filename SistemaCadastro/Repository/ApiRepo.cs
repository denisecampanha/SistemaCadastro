using SistemaCadastro.Commons;

namespace SistemaCadastro.Repository
{
    public class ApiRepo
    {
        private readonly HttpClient _httpClient = new();

        public async Task<Result> GetCepAsync(string url)
        {
            HttpResponseMessage resposta = await _httpClient.GetAsync(url);
            string conteudo = await resposta.Content.ReadAsStringAsync();

            return new(true, conteudo);
        }

    }
}
