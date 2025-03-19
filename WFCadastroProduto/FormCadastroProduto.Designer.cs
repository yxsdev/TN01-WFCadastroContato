namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            lblCódigo = new Label();
            lblCategoria = new Label();
            txtCodigo = new TextBox();
            nudPreco = new NumericUpDown();
            lblPreco = new Label();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            cmbCategoria = new ComboBox();
            lblDataVencimento = new Label();
            dtpDataVencimento = new DateTimePicker();
            lblObservacao = new Label();
            btnSalvar = new Button();
            txtObservacao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCódigo
            // 
            lblCódigo.AutoSize = true;
            lblCódigo.Location = new Point(69, 60);
            lblCódigo.Name = "lblCódigo";
            lblCódigo.Size = new Size(49, 15);
            lblCódigo.TabIndex = 0;
            lblCódigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(226, 60);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(69, 78);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // nudPreco
            // 
            nudPreco.Location = new Point(69, 204);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 3;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(69, 186);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(69, 123);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(106, 15);
            lblNomeProduto.TabIndex = 5;
            lblNomeProduto.Text = "Nome do produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(69, 141);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(356, 23);
            txtNomeProduto.TabIndex = 6;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Frutas", "", "Legumes", "", "Carnes", "", "Laticínios", "", "Grãos e Cereais", "", "Bebidas", "", "Sobremesas", "", "Pães e Massas", "", "Snacks", "", "Condimentos e Temperos" });
            cmbCategoria.Location = new Point(226, 78);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(199, 23);
            cmbCategoria.TabIndex = 7;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(226, 186);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(116, 15);
            lblDataVencimento.TabIndex = 8;
            lblDataVencimento.Text = "Data de vencimento:";
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Location = new Point(225, 204);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(200, 23);
            dtpDataVencimento.TabIndex = 9;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(69, 250);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(72, 15);
            lblObservacao.TabIndex = 10;
            lblObservacao.Text = "Observação:";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleRight;
            btnSalvar.Location = new Point(327, 366);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 40);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar:";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(69, 268);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(356, 82);
            txtObservacao.TabIndex = 12;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(txtObservacao);
            Controls.Add(btnSalvar);
            Controls.Add(lblObservacao);
            Controls.Add(dtpDataVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(cmbCategoria);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblPreco);
            Controls.Add(nudPreco);
            Controls.Add(txtCodigo);
            Controls.Add(lblCategoria);
            Controls.Add(lblCódigo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCódigo;
        private Label lblCategoria;
        private TextBox txtCodigo;
        private NumericUpDown nudPreco;
        private Label lblPreco;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private ComboBox cmbCategoria;
        private Label lblDataVencimento;
        private DateTimePicker dtpDataVencimento;
        private Label lblObservacao;
        private Button btnSalvar;
        private TextBox txtObservacao;
    }
}