namespace SistemaCadastro
{
    partial class frmFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabConsulta = new TabPage();
            btnNovo = new Button();
            btnExcluir = new Button();
            grdPesquisaFornecedor = new DataGridView();
            txtPesqFornecedor = new TextBox();
            label1 = new Label();
            tabCadastro = new TabPage();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtCidade = new TextBox();
            label18 = new Label();
            txtUf = new TextBox();
            label16 = new Label();
            txtBairro = new TextBox();
            label17 = new Label();
            txtCep = new TextBox();
            label15 = new Label();
            txtNum = new TextBox();
            label14 = new Label();
            chkAtivo = new CheckBox();
            txtEndereco = new TextBox();
            label4 = new Label();
            txtCNPJ = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPesquisaFornecedor).BeginInit();
            tabCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabConsulta);
            tabControl1.Controls.Add(tabCadastro);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(946, 629);
            tabControl1.TabIndex = 0;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(btnNovo);
            tabConsulta.Controls.Add(btnExcluir);
            tabConsulta.Controls.Add(grdPesquisaFornecedor);
            tabConsulta.Controls.Add(txtPesqFornecedor);
            tabConsulta.Controls.Add(label1);
            tabConsulta.Location = new Point(4, 29);
            tabConsulta.Margin = new Padding(3, 4, 3, 4);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3, 4, 3, 4);
            tabConsulta.Size = new Size(938, 596);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom;
            btnNovo.Location = new Point(783, 518);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(91, 41);
            btnNovo.TabIndex = 11;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Location = new Point(73, 518);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(91, 41);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // grdPesquisaFornecedor
            // 
            grdPesquisaFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdPesquisaFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPesquisaFornecedor.Location = new Point(33, 112);
            grdPesquisaFornecedor.Margin = new Padding(3, 4, 3, 4);
            grdPesquisaFornecedor.MultiSelect = false;
            grdPesquisaFornecedor.Name = "grdPesquisaFornecedor";
            grdPesquisaFornecedor.ReadOnly = true;
            grdPesquisaFornecedor.RowHeadersWidth = 51;
            grdPesquisaFornecedor.RowTemplate.Height = 24;
            grdPesquisaFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdPesquisaFornecedor.Size = new Size(872, 359);
            grdPesquisaFornecedor.TabIndex = 9;
            grdPesquisaFornecedor.CellDoubleClick += grdPesquisaFornecedor_CellDoubleClick_1;
            // 
            // txtPesqFornecedor
            // 
            txtPesqFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesqFornecedor.BorderStyle = BorderStyle.FixedSingle;
            txtPesqFornecedor.Location = new Point(122, 37);
            txtPesqFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtPesqFornecedor.Name = "txtPesqFornecedor";
            txtPesqFornecedor.Size = new Size(783, 27);
            txtPesqFornecedor.TabIndex = 8;
            txtPesqFornecedor.KeyPress += txtPesqFornecedor_KeyPress_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 40);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 7;
            label1.Text = "Pesquisar:";
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(btnCancelar);
            tabCadastro.Controls.Add(btnSalvar);
            tabCadastro.Controls.Add(txtCidade);
            tabCadastro.Controls.Add(label18);
            tabCadastro.Controls.Add(txtUf);
            tabCadastro.Controls.Add(label16);
            tabCadastro.Controls.Add(txtBairro);
            tabCadastro.Controls.Add(label17);
            tabCadastro.Controls.Add(txtCep);
            tabCadastro.Controls.Add(label15);
            tabCadastro.Controls.Add(txtNum);
            tabCadastro.Controls.Add(label14);
            tabCadastro.Controls.Add(chkAtivo);
            tabCadastro.Controls.Add(txtEndereco);
            tabCadastro.Controls.Add(label4);
            tabCadastro.Controls.Add(txtCNPJ);
            tabCadastro.Controls.Add(label3);
            tabCadastro.Controls.Add(txtNome);
            tabCadastro.Controls.Add(label2);
            tabCadastro.Location = new Point(4, 29);
            tabCadastro.Margin = new Padding(3, 4, 3, 4);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3, 4, 3, 4);
            tabCadastro.Size = new Size(938, 596);
            tabCadastro.TabIndex = 1;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(95, 373);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 41);
            btnCancelar.TabIndex = 57;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.None;
            btnSalvar.Location = new Point(725, 373);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 41);
            btnSalvar.TabIndex = 56;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.None;
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Location = new Point(95, 288);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(564, 27);
            txtCidade.TabIndex = 53;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Location = new Point(32, 290);
            label18.Name = "label18";
            label18.Size = new Size(56, 20);
            label18.TabIndex = 52;
            label18.Text = "Cidade";
            // 
            // txtUf
            // 
            txtUf.Anchor = AnchorStyles.None;
            txtUf.BorderStyle = BorderStyle.FixedSingle;
            txtUf.Location = new Point(725, 283);
            txtUf.Margin = new Padding(3, 4, 3, 4);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(162, 27);
            txtUf.TabIndex = 51;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Location = new Point(693, 288);
            label16.Name = "label16";
            label16.Size = new Size(26, 20);
            label16.TabIndex = 50;
            label16.Text = "UF";
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.None;
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Location = new Point(95, 235);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(792, 27);
            txtBairro.TabIndex = 49;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Location = new Point(40, 237);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 48;
            label17.Text = "Bairro";
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.None;
            txtCep.BorderStyle = BorderStyle.FixedSingle;
            txtCep.Location = new Point(725, 130);
            txtCep.Margin = new Padding(3, 4, 3, 4);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(162, 27);
            txtCep.TabIndex = 47;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new Point(688, 137);
            label15.Name = "label15";
            label15.Size = new Size(34, 20);
            label15.TabIndex = 46;
            label15.Text = "CEP";
            // 
            // txtNum
            // 
            txtNum.Anchor = AnchorStyles.None;
            txtNum.BorderStyle = BorderStyle.FixedSingle;
            txtNum.Location = new Point(725, 180);
            txtNum.Margin = new Padding(3, 4, 3, 4);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(162, 27);
            txtNum.TabIndex = 45;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(681, 187);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 44;
            label14.Text = "Núm";
            // 
            // chkAtivo
            // 
            chkAtivo.Anchor = AnchorStyles.None;
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(821, 82);
            chkAtivo.Margin = new Padding(3, 4, 3, 4);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(66, 24);
            chkAtivo.TabIndex = 8;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.None;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Location = new Point(95, 180);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(564, 27);
            txtEndereco.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(18, 182);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Anchor = AnchorStyles.None;
            txtCNPJ.BorderStyle = BorderStyle.FixedSingle;
            txtCNPJ.Location = new Point(95, 130);
            txtCNPJ.Margin = new Padding(3, 4, 3, 4);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(564, 27);
            txtCNPJ.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(48, 137);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "CNPJ";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(95, 81);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(696, 27);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(39, 83);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // frmFornecedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(946, 629);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Fornecedores";
            Load += frmFornecedores_Load;
            tabControl1.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPesquisaFornecedor).EndInit();
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAtivo;
        private TextBox txtCidade;
        private Label label18;
        private TextBox txtUf;
        private Label label16;
        private TextBox txtBairro;
        private Label label17;
        private TextBox txtCep;
        private Label label15;
        private TextBox txtNum;
        private Label label14;
        private Button btnNovo;
        private Button btnExcluir;
        private DataGridView grdPesquisaFornecedor;
        private TextBox txtPesqFornecedor;
        private Label label1;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}