﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WFCadastroProduto.Usuário;

namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Login = "admin";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("18/03/2025");
            us.HoraCadastro = new TimeOnly(18, 30, 00);

            /*us.DataCadastro = DateTime.Parse("18/03/2025 18:30")*/

            Usuario.ListaUsuarios.Add(us);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Usuario.ListaUsuarios)
            {
                if ((us.Login == txtLogin.Text) && (us.Senha == txtSenha.Text))
                {
                    MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    FormMenu Main = new FormMenu();
                    Main.Show();

                    txtLogin.Clear();
                    txtSenha.Clear();

                    return;
                }
            }

            txtSenha.Clear();
            MessageBox.Show("Usuario Não Autenticado!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcessar_Click(sender, e);
            }
        }
    }
}
       
