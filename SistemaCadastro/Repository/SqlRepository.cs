using Microsoft.Data.SqlClient;
using SistemaCadastro.Models;
using System.Data;
using System.Text.Json;
using System.Text.Json.Nodes;


namespace SistemaCadastro.Repository
{
    public class SqlRepository(string conn)
    {
        private readonly Context _context = new(conn);
        private readonly SqlConnection _connection = new(conn);

        public bool CreateFornecedor(string cnpj, string nome, string cep, string uf, string bairro, string cidade, string numero, string rua, bool ativo)
        {
            try
            {
                SistemaCadastro.Repository.Models.Fornecedor addFornecedor = new()
                {
                    Nome = nome,
                    CNPJ = cnpj,
                    CEP = cep,
                    UF = uf,
                    Bairro = bairro,
                    Cidade = cidade,
                    Numero = numero,
                    Rua = rua,
                    Ativo = ativo,
                    UpdateDate = DateTime.Now.ToString(),
                    CreateDate = DateTime.Now.ToString()
                };

                var fornecedor = _context.Fornecedor.Add(addFornecedor);

                int Rows = _context.SaveChanges();

                return Rows != 0;
            }
            catch (Exception e) 
            { 
                return false; 
            }
        }

        public bool UpdateFornecedor(int id, string nome, string cep, string UF, string bairro, string cidade, string numero, string rua, bool ativo)
        {
            try
            {
                var fornecedor = _context.Fornecedor.Find(id);

                if (fornecedor is null) 
                { 
                    return false; 
                }

                fornecedor.Ativo = ativo;
                fornecedor.CEP = cep;
                fornecedor.Nome = nome;
                fornecedor.UF = UF;
                fornecedor.Bairro = bairro;
                fornecedor.Cidade = cidade;
                fornecedor.Numero = numero;
                fornecedor.Rua = rua;
                fornecedor.UpdateDate = DateTime.Now.ToString();

                int effectRows = _context.SaveChanges();

                return effectRows != 0;
            }
            catch (Exception e) 
            { 
                return false; 
            }
        }

        public bool DeleteFornecedor(int id)
        {
            var fornecedor = _context.Fornecedor.Find(id);

            _context.Fornecedor.Remove(fornecedor);

            int effectRows = _context.SaveChanges();

            return effectRows != 0;

        }

        public bool CreateProduto(int fornecedorId, string nome, string referencia, string categoria, string grupo, string tabpreco, string observacao, int quantidade)
        {
            try
            {
                SistemaCadastro.Repository.Models.Produto addProduto = new();

                addProduto.Nome = nome;
                addProduto.Quantidade = quantidade; 
                addProduto.FornecedorId = fornecedorId; 
                addProduto.Referencia = referencia; 
                addProduto.Categoria = categoria ; 
                addProduto.Grupo = grupo; 
                addProduto.TabPreco = tabpreco; 
                addProduto.Observacao = observacao; 
                addProduto.CreateDate = DateTime.Now.ToString();
                addProduto.UpdateDate = DateTime.Now.ToString();

                var produto = _context.Produto.Add(addProduto);

                int effectRows = _context.SaveChanges();

                return effectRows != 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateProduto(int id, int fornecedorId, string nome, string referencia, string categoria, string grupo, string tabpreco, string observacao, int quantidade)

        {
            try
            {
                var produto = _context.Produto.Find(id);

                if (produto is null) 
                { 
                    return false; 
                }

                produto.Nome = nome;
                produto.Quantidade = quantidade;
                produto.FornecedorId = fornecedorId;
                produto.Referencia = referencia;
                produto.Categoria = categoria;
                produto.Grupo = grupo;
                produto.TabPreco = tabpreco;
                produto.Observacao = observacao;
                produto.UpdateDate = DateTime.Now.ToString();

                int effectRows = _context.SaveChanges();

                return effectRows != 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool DeleteProduto(int id)
        {
            var produto = _context.Produto.Find(id);

            _context.Produto.Remove(produto);

            int effectRows = _context.SaveChanges();

            return effectRows != 0;

        }


        public (bool, string?) Auth(string sql)
        {
            Connect();

            try
            {
                SqlCommand command = new(sql, _connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                { 
                    while (reader.Read()) 
                    { 
                        return (true, reader["Nome"].ToString()); 
                    } 
                }

                return (false, null);
            }
            catch (Exception ex)
            {
                return (false, $"Erro ao conectar o banco de dados: {ex.Message}");
            }
        }

        public Result ConsultaFornecedor(string sql)
        {
            Connect();

            SqlCommand command = new(sql, _connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                JsonArray fornecedores = [];

                while (reader.Read())
                {
                    JsonObject fornecedor = [];

                    fornecedor.Add("Id", Convert.ToInt32(reader["Id"]));
                    fornecedor.Add("Nome", reader["Nome"].ToString());
                    fornecedor.Add("CNPJ", reader["CNPJ"].ToString());
                    fornecedor.Add("Endereco", reader["Endereco"].ToString());
                    fornecedor.Add("Ativo", Convert.ToBoolean(reader["Ativo"]));
                    fornecedor.Add("Rua", reader["Rua"].ToString());
                    fornecedor.Add("Numero", reader["Numero"].ToString());
                    fornecedor.Add("Bairro", reader["Bairro"].ToString());
                    fornecedor.Add("CEP", reader["CEP"].ToString());
                    fornecedor.Add("Cidade", reader["Cidade"].ToString());
                    fornecedor.Add("UF", reader["UF"].ToString());

                    fornecedores.Add(fornecedor);
                }

                return new(true, JsonSerializer.Serialize(fornecedores));
            }

            return new(false, null);
        }

        public Result ConsultaProduto(string sql)
        {
            Connect();

            SqlCommand command = new(sql, _connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                JsonArray produtos = [];

                while (reader.Read())
                {
                    JsonObject produto = [];
                    produto.Add("Id", Convert.ToInt32(reader["Id"]));
                    produto.Add("Nome", reader["Nome"].ToString());
                    produto.Add("Fornecedor", reader["Fornecedor"].ToString());
                    produto.Add("Quantidade", Convert.ToInt32(reader["Quantidade"]));
                    produto.Add("Referencia", reader["Referencia"].ToString());
                    produto.Add("Categoria", reader["Categoria"].ToString());
                    produto.Add("Grupo", reader["Grupo"].ToString());
                    produto.Add("TabPreco", reader["TabPreco"].ToString());
                    produto.Add("Observacao", reader["Observacao"].ToString());

                    produtos.Add(produto);
                }

                return new(true, JsonSerializer.Serialize(produtos));
            }

            return new(false, null);
        }

        private void Connect()
        {
            try
            {
                _connection.Close();

                if (_connection.State == ConnectionState.Broken) 
                { 
                    _connection.Close(); 
                }

                if (_connection.State == ConnectionState.Closed) 
                { 
                    _connection.Open(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar o banco de dados: {ex.Message}");
            }
        }


    }
}
