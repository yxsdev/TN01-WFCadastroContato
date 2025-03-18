using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
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
            us.Codigo = 1000;
            us.Login = "user";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("10/01/2025");
            us.HoraCadastro = new TimeOnly(18, 30, 00);
            Usuario.ListaUsuarios.Add(us);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLogin.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        FormMain Main = new FormMain();
                        Main.Show();
                        return;
                    }
                }

            }

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
