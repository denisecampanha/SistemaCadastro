using SistemaCadastro.Business;

namespace SistemaCadastro.Forms
{
    public partial class frmMenu : Form
    {
        public SistemaCadastroBusiness _business { get; set; }

        public frmMenu(string usuario, SistemaCadastroBusiness business)
        {
            InitializeComponent();

            lblUsu.Text = "Usuário: " + usuario;

            _business = business;

            this.IsMdiContainer = true;

            frmLogin login = new();

            login.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedores formFornecedores = new(_business)
            {
                MdiParent = this
            };

            formFornecedores.Show();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos formProdutos = new(_business)
            {
                MdiParent = this
            };

            formProdutos.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
