namespace WFCadastroProduto
{
    partial class FormLogin
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
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(96, 80);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(96, 98);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe o login...";
            txtLogin.Size = new Size(131, 23);
            txtLogin.TabIndex = 1;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(96, 155);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe a senha...";
            txtSenha.Size = new Size(131, 23);
            txtSenha.TabIndex = 3;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(96, 137);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(152, 211);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 310);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnAcessar;
    }
}