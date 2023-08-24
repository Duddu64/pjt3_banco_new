using ReaLTaiizor.Forms;
namespace exemplo_treino
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.MdiParent = this;
            form.Show();
        }
    }
}