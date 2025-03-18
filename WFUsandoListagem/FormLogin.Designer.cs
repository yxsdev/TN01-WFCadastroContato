namespace WFUsandoListagem
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
            btnAcessar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(152, 183);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 13;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(86, 122);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe a senha...";
            txtSenha.Size = new Size(141, 23);
            txtSenha.TabIndex = 10;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(86, 104);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(86, 78);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe o login...";
            txtLogin.Size = new Size(141, 23);
            txtLogin.TabIndex = 8;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(86, 60);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Login:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 254);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtLogin;
        private Label lblLogin;
    }
}