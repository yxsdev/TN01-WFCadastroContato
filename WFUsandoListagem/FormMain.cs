namespace WFUsandoListagem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
