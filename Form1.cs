using Libras_para_todos;

namespace LIBRAS_PARA_TODOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlfabeto_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            FormAlfabeto telaAlfabeto = new FormAlfabeto();

            telaAlfabeto.ShowDialog();

            this.Show();
        }

        private void btnNumSin_Click(object sender, EventArgs e)
        {
            // MEU CÓDIGO AQUI (Numerais e Sinais)

            this.Hide(); // Esconde o menu principal (forms1)

            FormNumerais telaNumerais = new FormNumerais();

            telaNumerais.ShowDialog(); // Mostra tela

            this.Show(); 
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            FormJogoDaMemoria telajogodamemoria = new FormJogoDaMemoria();

            telajogodamemoria.ShowDialog(); 

            this.Show();
        }

        private void btnQuem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde o menu principal (forms1)

            FormQuemSomos telaQuemSomos = new FormQuemSomos();

            telaQuemSomos.ShowDialog(); // Mostra tela

            this.Show();
        }

        private void btnLibras_Click(object sender, EventArgs e)
        {
            // MEU CÓDIGO AQUI (O que é Libras?)

            this.Hide(); // Esconde o menu principal (forms1)

            FormOQueELibras telaLibras = new FormOQueELibras();

            telaLibras.ShowDialog(); // Mostra tela

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
