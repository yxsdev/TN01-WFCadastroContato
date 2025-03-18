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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparFormulario()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                Erro("Campo Login não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Erro("Campo Senha não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                Erro("Campo Confirma Senha não pode estar Vazio!");
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                Erro("Senhas não conferem!");
                return;
            }

            Usuario us1 = new Usuario();
            us1.Codigo = 0;
            us1.Login = txtLogin.Text;
            us1.Senha = txtSenha.Text;
            us1.ConfirmarSenha = txtConfirmarSenha.Text;
            us1.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(us1);

            FormListagem frmListagem = new FormListagem();
            frmListagem.ShowDialog();

            Sucesso("Cadastrado com Sucesso!");

            LimparFormulario();
        }
    }
}
