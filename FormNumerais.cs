using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRAS_PARA_TODOS.Properties; // Importa os Recursos

namespace LIBRAS_PARA_TODOS
{
    public partial class FormNumerais : Form
    {
        public FormNumerais()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            // Apenas fecha este formulário.
            // O Form1 (menu) que o chamou voltará a aparecer.
            this.Close();
        }

        // NOVO: Este é o método de clique para TODAS as imagens pequenas
        private void picPequeno_Click(object sender, EventArgs e)
        {
            // 1. Identifica qual PictureBox foi clicado
            PictureBox picClicado = (PictureBox)sender;
        
            picGrandeDisplay.BackgroundImage = null;// Remove a imagem de fundo ("verso")
            picGrandeDisplay.BorderStyle = BorderStyle.None;// Remove a borda (moldura)

            // 2. Pega a imagem desse PictureBox...
            // 3. ...e a exibe no PictureBox grande
            picGrandeDisplay.Image = picClicado.BackgroundImage;
        }

        private void FormNumerais_Load(object sender, EventArgs e)
        {

        }
    }
}
