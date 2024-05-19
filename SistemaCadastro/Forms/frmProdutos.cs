

using SistemaCadastro.Business;
using System.Data;

namespace SistemaCadastro
{
    public partial class frmProdutos : Form
    {

        private readonly SistemaCadastroBusiness _business;
        private List<SistemaCadastro.Models.Produto> listProduto;
        private List<SistemaCadastro.Models.Fornecedor> listFornecedor;
        private int? produtoId;
        private int? fornecedorId;
        private string fornecedorNome;

        public frmProdutos(SistemaCadastroBusiness business)
        {
            InitializeComponent();

            _business = business;

            CarregaGrid();

            CarregaComboBox();

        }

        public void CarregaComboBox()
        {
            cboFornecedor.Enabled = true;
            cboFornecedor.DataSource = null;

            var (resultado, listFornecedor) = _business.GetFornecedor("", "S");
            cboFornecedor.DataSource = listFornecedor.Select(x => new { x.Id, x.Nome }).ToList();
            cboFornecedor.DisplayMember = "Nome";
            cboFornecedor.ValueMember = "Id";

            if (fornecedorNome is null)
            {
                cboFornecedor.SelectedIndex = -1;
            }
            else 
            {
                cboFornecedor.SelectedText = fornecedorNome.ToString();
            }
        }

        private void CarregaGrid(string nome = null)
        {
            (var resultado, listProduto) = _business.GetProduto(nome);

            if (listProduto is null)
            {
                grdPesquisaProduto.DataSource = null;
            }

            else
            {
                grdPesquisaProduto.DataSource = grdPesquisaProduto.DataSource = listProduto.Select(x => new { x.Id, x.Nome, x.Fornecedor, x.Quantidade, x.Referencia, x.Categoria, x.Grupo, x.TabPreco, x.Observacao }).ToList();

                grdPesquisaProduto.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grdPesquisaProduto.Columns["Fornecedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grdPesquisaProduto.Columns["Observacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                grdPesquisaProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void txtPesqFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void grdPesquisaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdPesquisaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {

            if (e.RowIndex >= 0 && e.RowIndex < grdPesquisaProduto.Rows.Count)
            {
                var id = grdPesquisaProduto.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (!int.TryParse(id.ToString(), out int intId))
                {
                    MessageBox.Show("Erro ao carregar dados do Produto!");
                }
                else
                {
                    produtoId = intId;

                    var produto = listProduto.FirstOrDefault(f => f.Id == intId);

                    if (produto is not null)
                    {
                        fornecedorNome = produto.Fornecedor.ToString();

                        CarregaComboBox();

                        txtNome.Text = produto.Nome.ToString();
                        cboFornecedor.Text = produto.Fornecedor.ToString();
                        txtReferencia.Text = produto.Referencia.ToString();
                        txtCategoria.Text = produto.Categoria.ToString();
                        txtGrupo.Text = produto.Grupo.ToString();
                        txtTabPreco.Text = produto.TabPreco.ToString();
                        txtObs.Text = produto.Observacao.ToString();

                        numericUpDown1.Text = produto.Quantidade.ToString();

                        tabControl1.SelectTab(1);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao carregar dados do Produto!");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) 
        {
            if (grdPesquisaProduto.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = grdPesquisaProduto.SelectedRows[0];

                var id = linhaSelecionada.Cells["Id"].Value;

                _business.DeleteProduto(id.ToString());

                MessageBox.Show("Produto excluído com Sucesso!");

                CarregaGrid();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e) 
        {

            CarregaComboBox();

            cboFornecedor.SelectedIndex = -1;

            numericUpDown1.Value = 0;

            cboFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;

            tabControl1.SelectTab(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!fornecedorId.HasValue)
            {
                MessageBox.Show("Selecione o fornecedor!");
            }
            else
            {
                if (produtoId.HasValue)
                {
                    _business.UpdateProduto(produtoId.Value, fornecedorId.Value, txtNome.Text, txtReferencia.Text, txtCategoria.Text, txtGrupo.Text, txtTabPreco.Text, txtObs.Text, numericUpDown1.Value.ToString());

                    MessageBox.Show("Produto atualizado com Sucesso!");
                }
                else
                {
                    _business.PostProduto(fornecedorId.Value, txtNome.Text, txtReferencia.Text, txtCategoria.Text, txtGrupo.Text, txtTabPreco.Text, txtObs.Text, numericUpDown1.Value.ToString());

                    MessageBox.Show("Produto cadastrado com Sucesso!");
                }

                if (true)
                {
                    produtoId = null;

                    fornecedorId = null;
                }

                CarregaGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) 
        {
            tabControl1.SelectTab(0);
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFornecedor.SelectedValue is not null && int.TryParse(cboFornecedor.SelectedValue.ToString(), out int id))
            {
                fornecedorId = id;
            }
        }

        private void txtPesqProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               CarregaGrid(txtPesqProduto.Text);
            }
        }
    }
}
