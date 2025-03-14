namespace TN01_WFCadastroContato
{
    partial class FormContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContato));
            lblNome = new Label();
            txtNome = new TextBox();
            lblLinha = new Label();
            txtSobrenome = new TextBox();
            lblSobrenome = new Label();
            lblTelefone = new Label();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbPessoal = new RadioButton();
            rdbComercial = new RadioButton();
            label2 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mtbTelefone = new MaskedTextBox();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(50, 47);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(216, 23);
            txtNome.TabIndex = 1;
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(50, 107);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(550, 1);
            lblLinha.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(291, 65);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(309, 23);
            txtSobrenome.TabIndex = 4;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(291, 47);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(71, 15);
            lblSobrenome.TabIndex = 3;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(50, 124);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(83, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "DDD/Telefone:";
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Location = new Point(291, 127);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(309, 48);
            gbxTipoTelefone.TabIndex = 7;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(217, 20);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(7, 20);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 1;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(105, 19);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 0;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(50, 205);
            label2.Name = "label2";
            label2.Size = new Size(550, 1);
            label2.TabIndex = 8;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleRight;
            btnVoltar.Location = new Point(395, 320);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(105, 42);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleRight;
            btnSalvar.Location = new Point(508, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 42);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(550, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail:";
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(50, 147);
            mtbTelefone.Mask = "(99) 00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(216, 23);
            mtbTelefone.TabIndex = 13;
            mtbTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbTelefone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // FormContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 388);
            Controls.Add(mtbTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(label2);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobrenome);
            Controls.Add(lblLinha);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormContato";
            Text = "FormContato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblLinha;
        private TextBox txtSobrenome;
        private Label lblSobrenome;
        private Label lblTelefone;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbPessoal;
        private RadioButton rdbComercial;
        private Label label2;
        private Button btnVoltar;
        private Button btnSalvar;
        private TextBox txtEmail;
        private Label lblEmail;
        private MaskedTextBox mtbTelefone;
    }
}