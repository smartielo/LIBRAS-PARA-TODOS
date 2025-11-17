namespace LIBRAS_PARA_TODOS //
{
    public partial class FormOQueELibras : Form
    {
        public FormOQueELibras()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // CÓDIGO CORRIGIDO:
            // Apenas fecha este formulário. O Form1 (menu) que o chamou
            // voltará a aparecer automaticamente.
            this.Close();
        }

        private void FormOQueELibras_Load(object sender, EventArgs e)
        {

        }
    }
}