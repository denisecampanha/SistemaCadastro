namespace SistemaCadastro
{
    partial class frmProdutos
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
            grdPesquisaProduto = new DataGridView();
            txtPesqProduto = new TextBox();
            label1 = new Label();
            tabCadastro = new TabPage();
            txtObs = new TextBox();
            txtTabPreco = new TextBox();
            txtGrupo = new TextBox();
            txtCategoria = new TextBox();
            txtReferencia = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            cboFornecedor = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPesquisaProduto).BeginInit();
            tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            tabControl1.TabIndex = 1;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(btnNovo);
            tabConsulta.Controls.Add(btnExcluir);
            tabConsulta.Controls.Add(grdPesquisaProduto);
            tabConsulta.Controls.Add(txtPesqProduto);
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
            btnNovo.Location = new Point(791, 531);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(91, 41);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Location = new Point(53, 531);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(91, 41);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // grdPesquisaProduto
            // 
            grdPesquisaProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdPesquisaProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPesquisaProduto.Location = new Point(23, 125);
            grdPesquisaProduto.Margin = new Padding(3, 4, 3, 4);
            grdPesquisaProduto.MultiSelect = false;
            grdPesquisaProduto.Name = "grdPesquisaProduto";
            grdPesquisaProduto.ReadOnly = true;
            grdPesquisaProduto.RowHeadersWidth = 51;
            grdPesquisaProduto.RowTemplate.Height = 24;
            grdPesquisaProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdPesquisaProduto.Size = new Size(872, 359);
            grdPesquisaProduto.TabIndex = 2;
            grdPesquisaProduto.CellContentClick += grdPesquisaProduto_CellContentClick;
            grdPesquisaProduto.CellDoubleClick += grdPesquisaProduto_CellDoubleClick;
            // 
            // txtPesqProduto
            // 
            txtPesqProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesqProduto.BorderStyle = BorderStyle.FixedSingle;
            txtPesqProduto.Location = new Point(112, 50);
            txtPesqProduto.Margin = new Padding(3, 4, 3, 4);
            txtPesqProduto.Name = "txtPesqProduto";
            txtPesqProduto.Size = new Size(783, 27);
            txtPesqProduto.TabIndex = 1;
            txtPesqProduto.KeyPress += txtPesqProduto_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 53);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar:";
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(txtObs);
            tabCadastro.Controls.Add(txtTabPreco);
            tabCadastro.Controls.Add(txtGrupo);
            tabCadastro.Controls.Add(txtCategoria);
            tabCadastro.Controls.Add(txtReferencia);
            tabCadastro.Controls.Add(label9);
            tabCadastro.Controls.Add(label8);
            tabCadastro.Controls.Add(label7);
            tabCadastro.Controls.Add(label6);
            tabCadastro.Controls.Add(label5);
            tabCadastro.Controls.Add(numericUpDown1);
            tabCadastro.Controls.Add(cboFornecedor);
            tabCadastro.Controls.Add(btnSalvar);
            tabCadastro.Controls.Add(btnCancelar);
            tabCadastro.Controls.Add(label4);
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
            // txtObs
            // 
            txtObs.Anchor = AnchorStyles.None;
            txtObs.BorderStyle = BorderStyle.FixedSingle;
            txtObs.Location = new Point(124, 271);
            txtObs.Margin = new Padding(3, 4, 3, 4);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(773, 27);
            txtObs.TabIndex = 24;
            // 
            // txtTabPreco
            // 
            txtTabPreco.Anchor = AnchorStyles.None;
            txtTabPreco.BorderStyle = BorderStyle.FixedSingle;
            txtTabPreco.Location = new Point(584, 224);
            txtTabPreco.Margin = new Padding(3, 4, 3, 4);
            txtTabPreco.Name = "txtTabPreco";
            txtTabPreco.Size = new Size(313, 27);
            txtTabPreco.TabIndex = 23;
            // 
            // txtGrupo
            // 
            txtGrupo.Anchor = AnchorStyles.None;
            txtGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtGrupo.Location = new Point(124, 224);
            txtGrupo.Margin = new Padding(3, 4, 3, 4);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(310, 27);
            txtGrupo.TabIndex = 22;
            // 
            // txtCategoria
            // 
            txtCategoria.Anchor = AnchorStyles.None;
            txtCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtCategoria.Location = new Point(584, 174);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(313, 27);
            txtCategoria.TabIndex = 21;
            // 
            // txtReferencia
            // 
            txtReferencia.Anchor = AnchorStyles.None;
            txtReferencia.BorderStyle = BorderStyle.FixedSingle;
            txtReferencia.Location = new Point(124, 174);
            txtReferencia.Margin = new Padding(3, 4, 3, 4);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(310, 27);
            txtReferencia.TabIndex = 20;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(25, 273);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 19;
            label9.Text = "Observação:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(501, 176);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 18;
            label8.Text = "Categoria:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(455, 226);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 17;
            label7.Text = "Tabela de Preços:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(62, 226);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 16;
            label6.Text = "Grupo:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(33, 176);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 15;
            label5.Text = "Referência:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(124, 320);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(130, 27);
            numericUpDown1.TabIndex = 14;
            // 
            // cboFornecedor
            // 
            cboFornecedor.Anchor = AnchorStyles.None;
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(124, 123);
            cboFornecedor.Margin = new Padding(3, 4, 3, 4);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(773, 28);
            cboFornecedor.TabIndex = 13;
            cboFornecedor.SelectedIndexChanged += cboFornecedor_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.None;
            btnSalvar.Location = new Point(604, 439);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(91, 41);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(243, 439);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 41);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(31, 322);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(31, 126);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Fornecedor:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(124, 72);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(773, 27);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(62, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 629);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "frmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            tabControl1.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPesquisaProduto).EndInit();
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView grdPesquisaProduto;
        private System.Windows.Forms.TextBox txtPesqProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private TextBox txtObs;
        private TextBox txtTabPreco;
        private TextBox txtGrupo;
        private TextBox txtCategoria;
        private TextBox txtReferencia;
    }
}