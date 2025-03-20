namespace WFCadastroProduto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = 
                MessageBox.Show("Deseja realmente sair?", "Sair", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();
        }
    }
}
