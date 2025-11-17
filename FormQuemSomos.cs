using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libras_para_todos
{
    // Nome da classe atualizado de Form6 para FormQuemSomos
    public partial class FormQuemSomos : Form
    {
        private int contadorCliques = 0;
        private const int LIMITE_CLIQUES = 7;


        public FormQuemSomos()
        {
            InitializeComponent();
        }

        // CÓDIGO DO BOTÃO VOLTAR CORRIGIDO
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // Apenas fecha este formulário.
            // O Form1 (menu) que o chamou voltará a aparecer.
            this.Close();
        }

        // LÓGICA DA SURPRESA ATUALIZADA
        private void supresa_elvio_Click(object sender, EventArgs e)
        {
            contadorCliques++;
        }

        // --- Eventos vazios do seu colega, podem ser removidos ---
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e) { }
        private void Lbl_colab_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        private void lblDev1_Click(object sender, EventArgs e)
        {

        }

        private void lblDisciplina_Click(object sender, EventArgs e)
        {

        }

        private void lblDisciplina_Click_1(object sender, EventArgs e)
        {

        }

    }
}