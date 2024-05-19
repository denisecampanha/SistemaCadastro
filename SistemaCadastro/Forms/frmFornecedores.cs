using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using SistemaCadastro.Business;
using SistemaCadastro.Models;


namespace SistemaCadastro
{
    public partial class frmFornecedores : Form
    {
        private readonly SistemaCadastroBusiness _business;
        private int? fornecedorId = null;
        private List<Fornecedor> ListFornecedor;

        public frmFornecedores(SistemaCadastroBusiness busines)
        {
            InitializeComponent();
            _business = busines;

            CarregaGrid();

        }

        private void CarregaGrid(string nome = null)
        {

            (var resultado, ListFornecedor) = _business.GetFornecedor(nome);

            if (!resultado.Success)
            {
                MessageBox.Show(resultado.Message);
            }

            grdPesquisaFornecedor.DataSource = ListFornecedor?.Select(x => new { Id = x.Id, Nome = x.Nome, CNPJ = x.CNPJ, Endereco = x.Endereco, Ativo = x.Ativo }).ToList();

            grdPesquisaFornecedor.Columns["Endereco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grdPesquisaFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtPesqFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void grdPesquisaFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (fornecedorId.HasValue)
            {
                _business.UpdateFornecedor(fornecedorId.Value, txtNome.Text, txtCep.Text, txtUf.Text, txtBairro.Text, txtCidade.Text, txtNum.Text, txtEndereco.Text, chkAtivo.Checked);
                
                MessageBox.Show("Fornecedor atualizado com Sucesso!");
            }
            else
            {

                var resultado = _business.PostFornecedor(txtCNPJ.Text, txtNome.Text, txtCep.Text, txtUf.Text, txtBairro.Text, txtCidade.Text, txtNum.Text, txtEndereco.Text, chkAtivo.Checked);
                
                MessageBox.Show("Fornecedor cadastrado com Sucesso!");
            }

            fornecedorId = null;

            CarregaGrid();

        }

        private void grdPesquisaFornecedor_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grdPesquisaFornecedor.Rows.Count)
            {
                var id = grdPesquisaFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (!int.TryParse(id.ToString(), out int intId))
                {
                    MessageBox.Show("Erro ao carregar Dados!");
                }
                else
                {
                    fornecedorId = intId;

                    var fornecedor = ListFornecedor.FirstOrDefault(f => f.Id == intId);

                    if (fornecedor is not null)
                    {
                        txtNome.Text = fornecedor.Nome.ToString();
                        txtCNPJ.Text = fornecedor.CNPJ.ToString();
                        txtCep.Text = fornecedor.CEP.ToString();
                        txtEndereco.Text = fornecedor.Rua.ToString();
                        txtNum.Text = fornecedor.Numero.ToString();
                        txtBairro.Text = fornecedor.Bairro.ToString();
                        txtCidade.Text = fornecedor.Cidade.ToString();
                        txtUf.Text = fornecedor.UF.ToString();
                        chkAtivo.Checked = fornecedor.Ativo;

                        tabControl1.SelectTab(1);

                    }
                    else
                    {
                        MessageBox.Show("Erro ao carregar Dados!");
                    }
                }
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }


        private void txtPesqFornecedor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CarregaGrid(txtPesqFornecedor.Text);
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (grdPesquisaFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = grdPesquisaFornecedor.SelectedRows[0];

                var id = linhaSelecionada.Cells["Id"].Value;

                _business.DeleteFornecedor(id.ToString());

                MessageBox.Show("Fornecedor excluído com Sucesso!");

                CarregaGrid();
            }
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}
