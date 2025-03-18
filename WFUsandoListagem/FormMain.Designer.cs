namespace WFUsandoListagem
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            mnsMenu = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsListar = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            picMain = new PictureBox();
            mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).BeginInit();
            SuspendLayout();
            // 
            // mnsMenu
            // 
            mnsMenu.BackColor = SystemColors.Control;
            mnsMenu.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsListar, mnsSair });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(576, 24);
            mnsMenu.TabIndex = 0;
            mnsMenu.Text = "Menu";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(69, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += mnsCadastrar_Click;
            // 
            // mnsListar
            // 
            mnsListar.Name = "mnsListar";
            mnsListar.Size = new Size(47, 20);
            mnsListar.Text = "Listar";
            mnsListar.Click += mnsListar_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // picMain
            // 
            picMain.Image = (Image)resources.GetObject("picMain.Image");
            picMain.Location = new Point(5, 29);
            picMain.Name = "picMain";
            picMain.Size = new Size(566, 379);
            picMain.TabIndex = 1;
            picMain.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 413);
            Controls.Add(picMain);
            Controls.Add(mnsMenu);
            MainMenuStrip = mnsMenu;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenu;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsListar;
        private ToolStripMenuItem mnsSair;
        private PictureBox picMain;
    }
}
