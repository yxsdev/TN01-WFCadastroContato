﻿namespace WFCadastroProduto
{
    partial class FormListaProduto
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
            dgvListaProduto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaProduto).BeginInit();
            SuspendLayout();
            // 
            // dgvListaProduto
            // 
            dgvListaProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProduto.Location = new Point(12, 12);
            dgvListaProduto.Name = "dgvListaProduto";
            dgvListaProduto.Size = new Size(776, 426);
            dgvListaProduto.TabIndex = 1;
            // 
            // FormListaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaProduto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormListaProduto";
            Text = "Lista de Produto";
            Load += FormListaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaProduto;
    }
}