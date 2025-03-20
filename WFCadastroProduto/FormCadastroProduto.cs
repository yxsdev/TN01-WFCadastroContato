using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
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
            txtCodigo.Clear();
            txtNomeProduto.Clear();
            txtObservacao.Clear();
            nudPreco.Value = 0;
            cmbCategoria.SelectedIndex = -1;
            dtpDataVencimento.Value = DateTime.Today;
        }
        /*
        public bool CamposNaoPreenchidos()
        {
            if(string.IsNullOrEmpty(txtCodigo.Text) 
                return true;
            if(string.IsNullOrEmpty(txtNomeProduto.Text))
                return true;
            if(cbxCategoria.SelectedIndex == -1)
                return true;
            if(nudPreco.Value == 0)
                return true;
            if(dtpDataVencimento.Value == DateTime.Today)
                return true;

            return false;
        } 

        dentro do botão salvar
        {
            if(CamposNaoPreenchidos())
            {
                Erro("Preencha todos os campos!");
                return;
            }
            else
            {
            Produto p1 = new Produto();
            p1.Codigo = Convert.ToInt32(txtCodigo.Text);
            p1.NomeProduto = txtNomeProduto.Text;
            p1.Observacao = txtObservacao.Text;
            p1.Preco = Convert.ToDouble(nudPreco.Value);
            p1.Categoria = Convert.ToString(cmbCategoria.SelectedItem);
            p1.DataVencimento = dtpDataVencimento.Value;
            Produto.ListaProduto.Add(p1);
            FormListaProduto formListaProduto = new FormListaProduto();
            formListaProduto.Show();
            Sucesso("Cadastrado com Sucesso!");
            LimparFormulario();
            }
        }
        */

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Erro("Campo Código não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Erro("Campo Nome do Produto não pode estar Vazio!");
                return;
            }

            if (nudPreco.Value == 0)
            {
                Erro("Campo Preço não pode ser 0!");
                return;
            }
            else if (cmbCategoria.SelectedIndex == -1)
            {
                Erro("Selecione uma Categoria!");
                return;
            }
            else if (dtpDataVencimento.Value < DateTime.Now)
            {
                Erro("Data de Vencimento não pode ser menor que a data atual!");
                return;
            }

            Produto p1 = new Produto();
            p1.Codigo = Convert.ToInt32(txtCodigo.Text);
            p1.NomeProduto = txtNomeProduto.Text;
            p1.Observacao = txtObservacao.Text;
            p1.Preco = Convert.ToDouble(nudPreco.Value);
            p1.Categoria = Convert.ToString(cmbCategoria.SelectedItem);
            p1.DataVencimento = dtpDataVencimento.Value;

            Produto.ListaProduto.Add(p1);

            FormListaProduto formListaProduto = new FormListaProduto();
            formListaProduto.Show();

            Sucesso("Cadastrado com Sucesso!");

            LimparFormulario();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace (para apagar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                // Se a tecla pressionada não for um número ou Backspace, bloqueia a digitação
                e.Handled = true;
            }
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            dtpDataVencimento.Value = DateTime.Today;
        }
    }
}
