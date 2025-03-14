namespace TN01_WFCadastroContato
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormContato form = new FormContato();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
