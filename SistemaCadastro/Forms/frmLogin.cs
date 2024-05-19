
using SistemaCadastro.Business;
using SistemaCadastro.Forms;

namespace SistemaCadastro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SistemaCadastroBusiness business = new(@"Data Source=DSCM\SQLEXPRESS2;Initial Catalog=projetos;Integrated Security=True;User Id=sa;TrustServerCertificate=true;");
            
            var result = business.GetUsuario(txtUsuario.Text, txtSenha.Text);

            if (result.Success)
            {
                MessageBox.Show("Login efetuado com Sucesso!");

                frmMenu menu = new(result.Message, business);

                Hide();
                menu.Show();
 
            }
            else
            {
                MessageBox.Show("Usuário ou Senha não encontrado!");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
