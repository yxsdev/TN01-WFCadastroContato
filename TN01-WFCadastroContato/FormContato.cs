﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormContato : Form
    {
        public FormContato()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("Campo Nome não pode estar vazio!");
                return;
            }
            else if(string.IsNullOrEmpty(txtSobrenome.Text))
            {
                Erro("Campo Sobrenome não pode estar vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(mtbTelefone.Text))
            {
                Erro("Campo Telefone não pode estar vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo E-mail não pode estar vazio!");
                return;
            }

            string tipoTelefone = "";
            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção do tipo de telefone!");
                return;
            }
            else
            {
                if (rdbComercial.Checked)
                    tipoTelefone = "Comercial";
                else if (rdbPessoal.Checked)
                    tipoTelefone = "Pessoal";
                else 
                    tipoTelefone = "Recado";

            }

            //Jeito 1 (Retirando as marcaras do maskedtextbox)
            string dddtelefone = 
                "(" + mtbTelefone.Text.Substring(0, 2) + ")" 
                + mtbTelefone.Text.Substring(2, 5) + "-" 
                + mtbTelefone.Text.Substring(7);

            string mensagem = @$"
            Nome: {txtNome.Text} {txtSobrenome}
            Tipo de telefone: {tipoTelefone}
            DDD/Telefone {dddtelefone}
            Email: {txtEmail}";

            Sucesso(mensagem);
        }
    }
}
