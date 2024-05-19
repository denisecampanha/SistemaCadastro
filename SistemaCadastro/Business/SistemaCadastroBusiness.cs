
using SistemaCadastro.Models;
using SistemaCadastro.Repositorio;
using System.Text.Json;

namespace SistemaCadastro.Business
{
    public partial class SistemaCadastroBusiness(string conn)
    {
        private readonly SqlDataAccess _dataAccess = new(conn);

        public Result GetUsuario(string usuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(usuario)) 
            { 
                return new(false, "Usuario inválido!"); 
            }

            if (string.IsNullOrWhiteSpace(senha)) 
            { 
                return new(false, "Senha inválida!"); 
            }

            var (resultado, nome) = _dataAccess.GetUsuario(usuario, senha);
            return new(resultado, nome);
        }

        public Result DeleteFornecedor(string id)
        {
            if (!int.TryParse(id, out int identify))
            {
                return new(false, "Fornecedor não encontrado!");
            }

            var resultado = _dataAccess.DeleteFornecedor(identify);

            return new(resultado, "Fornecedor excluído com sucesso!");
        }


        public (Result, List<Fornecedor>?) GetFornecedor(string nome = null, string ativos = null)
        {
            var resultado = _dataAccess.GetFornecedor(nome, ativos);

            if (resultado.Success && !string.IsNullOrWhiteSpace(resultado.Message))
            {
               return (new(true, null), JsonSerializer.Deserialize<List<Fornecedor>>(resultado.Message));
            }

            return (new(false, "Não foi possível consultar o fornecedor!"), null);

        }

        public (Result, List<Produto>?) GetProduto(string? nome = null)
        {
            var resultado = _dataAccess.GetProduto(nome);

            if (resultado.Success && !string.IsNullOrWhiteSpace(resultado.Message))
            {
                return (new(true, null), JsonSerializer.Deserialize<List<Produto>>(resultado.Message));
            }

            return (new(false, "Não foi possivel consultar  o Produto!"), null);

        }

        public Result PostFornecedor(string cnpj, string nome, string cep, string estado, string bairro, string cidade, string numero, string rua, bool ativo)
        {
            
            var resultado = _dataAccess.PostFornecedor(cnpj, nome, cep, estado, bairro, cidade, numero, rua, ativo);

            if (!resultado)
            {
                return new(true, "Não foi possivel salvar o Fornecedor!");
            }

            return new(true, "Fornecedor salvo com Sucesso!");
        }

        public Result PostProduto(int fornecedorId, string nome, string referencia, string categoria, string grupo, string tabPreco, string observacao, string quantidade)
        {
            if (fornecedorId <= 0) 
            { 
                return new(false, "Selecione um Fornecedor!"); 
            }

            if (string.IsNullOrWhiteSpace(nome)) 
            { 
                return new(false, "Nome não pode ser nulo!"); 
            }

            if (!int.TryParse(quantidade, out var intQuantidade)) 
            { 
                return new(false, "Informe uma quantidade!"); 
            }

            var resultado = _dataAccess.PostProduto(fornecedorId, nome, referencia, categoria, grupo, tabPreco, observacao, intQuantidade);

            return new(resultado, "Produto cadastrado com Sucesso!");
        }
        public Result UpdateProduto(int id, int fornecedorid, string nome, string referencia, string categoria, string grupo, string tabPreco, string observacao, string quantidade)
        {
            if (id <= 0)
            {
                return new(false, "Produto não encontrado!");
            }
            if (fornecedorid <= 0)
            {
                return new(false, "Fornecedor não encontrado!");
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                return new(false, "Nome não pode ser vazio!");
            }

            if (!int.TryParse(quantidade, out var intQuantidade))
            {
                return new(false, "Informe a quantidade!");
            }

            var resultado = _dataAccess.UpdateProduto(id, fornecedorid, nome, referencia, categoria, grupo, tabPreco , observacao,  intQuantidade);

            return new(resultado, "Produto reprocessado com Sucesso!");
        }

        public Result DeleteProduto(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                if (int.TryParse(id, out int produtoId))
                {
                    return new(_dataAccess.DeleteProduto(produtoId), "Produto excluído com Sucesso!");
                }
            }

            return new(false, "Produto não encontrado!");
        }
        public Result UpdateFornecedor(int id, string nome, string cep, string estado, string bairro, string cidade, string numero, string rua, bool ativo)
        {
            if (id <= 0) 
            { 
                return new(false, "Fornecedor não encontrado!"); 
            }

            var resultado = _dataAccess.UpdateFornecedor(id, nome, cep, estado, bairro, cidade, numero, rua, ativo);

            return new(resultado, "Fornecedor atualizado com Sucesso!");
        }

    }
}



