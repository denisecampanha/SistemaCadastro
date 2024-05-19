using SistemaCadastro.Models;
using SistemaCadastro.Repository;

namespace SistemaCadastro.Repositorio
{
    public class SqlDataAccess(string conn)
    {
        private readonly SqlRepository _sqlRepo = new(conn);

        public (bool, string?) GetUsuario(string usuario, string senha)
        {
            string sql = $"SELECT NOME FROM DBO.USUARIO WHERE LOGIN = '{usuario}' AND SENHA = '{senha}'";

            return _sqlRepo.Auth(sql);

        }

        public Result GetFornecedor(string? nome = null, string? ativos = null)
        {
            string sql = "SELECT ID, NOME, CNPJ, CONCAT('Rua: ', RUA, ', Num. ', NUMERO, ' - Bairro: ', BAIRRO, ' - CEP: ', CEP, ' - Cidade: ', CIDADE, ' - UF: ', UF) AS ENDERECO, ATIVO, RUA, NUMERO, BAIRRO, CEP, CIDADE, UF FROM FORNECEDOR";
           
            if (!string.IsNullOrWhiteSpace(nome))
            {
                sql += $" WHERE NOME = '{nome}'";

                if (!string.IsNullOrWhiteSpace(ativos))
                {
                    sql += $" AND ATIVO = 1";
                }

            }
            else if (!string.IsNullOrWhiteSpace(ativos))
            {
                sql += $" WHERE ATIVO = 1";
            }

             return _sqlRepo.ConsultaFornecedor(sql);

        }
        
        public Result GetProduto(string? nome = null)
        {
            string sql = "SELECT P.ID, P.NOME, F.NOME AS FORNECEDOR, P.QUANTIDADE, P.REFERENCIA, P.CATEGORIA, P.GRUPO, P.TABPRECO, P.OBSERVACAO FROM PRODUTO P JOIN FORNECEDOR F ON P.FORNECEDORID = F.ID";

            if (!string.IsNullOrWhiteSpace(nome))
            {
                sql += $" WHERE P.NOME = '{nome}'";
            }

            return _sqlRepo.ConsultaProduto(sql);
        }

        public bool PostFornecedor(string cnpj, string nome, string cep, string uf, string bairro, string cidade, string numero, string rua, bool ativo)
        => _sqlRepo.CreateFornecedor(cnpj, nome, cep, uf, bairro, cidade, numero, rua, ativo);

        public bool PostProduto(int fornecedorid, string nome, string referencia, string categoria, string grupo, string tabPreco, string observacao, int quantidade)
        => _sqlRepo.CreateProduto(fornecedorid, nome, referencia, categoria, grupo, tabPreco, observacao, quantidade);

        public bool UpdateFornecedor(int id, string nome, string cep, string uf, string bairro, string cidade, string numero, string rua, bool ativo)
        => _sqlRepo.UpdateFornecedor(id, nome, cep, uf, bairro, cidade, numero, rua, ativo);

        public bool UpdateProduto(int id, int fornecedorid, string nome, string referencia, string categoria, string grupo, string tabPreco, string observacao, int quantidade)
        => _sqlRepo.UpdateProduto(id, fornecedorid, nome, referencia, categoria, grupo, tabPreco, observacao, quantidade);

        public bool DeleteFornecedor(int id)
        => _sqlRepo.DeleteFornecedor(id);

        public bool DeleteProduto(int id)
        => _sqlRepo.DeleteProduto(id);

    }
}
