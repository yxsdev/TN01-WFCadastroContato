namespace WFUsandoListagem
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtConfirmarSenha = new TextBox();
            lblConfirmarSenha = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(86, 65);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(86, 83);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe um login...";
            txtLogin.Size = new Size(141, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(86, 127);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe uma senha...";
            txtSenha.Size = new Size(141, 23);
            txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(86, 109);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(86, 176);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "Confirme a senha...";
            txtConfirmarSenha.Size = new Size(141, 23);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(86, 158);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(99, 15);
            lblConfirmarSenha.TabIndex = 4;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(115, 223);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 41);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 309);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Novos Usuários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtConfirmarSenha;
        private Label lblConfirmarSenha;
        private Button btnCadastrar;
    }
}