using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRAS_PARA_TODOS
{
    public partial class FormJogoDaMemoria : Form
    {
        public FormJogoDaMemoria()
        {
            InitializeComponent();
            inicio();
        }

        private void FormJogoDaMemoria_Load(object sender, EventArgs e)
        {

        }



        int movimentos, cliques, cartas_encontradas, tag_index;
        List<string> lista = new List<string>();
        int[] tags = new int[2];

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 pagina_quem_somos = new Form1();
            this.Hide();
            pagina_quem_somos.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inicio()
        {


            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                int tag_index = int.Parse(String.Format("{0}", item.Tag));

                item.BackgroundImage = item.Image;

                item.Image = Properties.Resources.verso;
                item.Enabled = true;

            }
            posicoes();


        }

        private void posicoes()
        {

            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();

                int[] xP = { 74, 229, 386, 536, 693 };
                int[] yP = { 37, 165, 301, 430 };

            Repete:
                var x = xP[rdn.Next(0, xP.Length)];
                var y = yP[rdn.Next(0, yP.Length)];
                item.Location = new Point(x, y);
                string verificacao = x.ToString() + y.ToString();

                if (lista.Contains(verificacao))
                {
                    goto Repete;

                }
                else
                {
                    item.Location = new Point(x, y);
                    lista.Add(verificacao);

                }

            }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        private void Imagensclicadas_Click(object sender, EventArgs e)
        {
            bool par_encontrado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;
            tag_index = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = pic.BackgroundImage;
            pic.Refresh();
            if (cliques == 1)
            {
                tags[0] = int.Parse(String.Format("{0}", pic.Tag));

            }
            else if (cliques == 2)
            {

                movimentos++;
                LblMovimentos.Text = "Movimentos: " + movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));
                par_encontrado = checagem_pares();
                desvirar(par_encontrado);

            }
        }

        private bool checagem_pares()
        {
            cliques = 0;
            if (tags[0] == tags[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void desvirar(bool check)
        {
            Thread.Sleep(200);


            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] || int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (check == true)
                    {
                        item.Enabled = false;
                        cartas_encontradas++;
                        final_jogo();
                    }
                    else
                    {
                        item.Image = Properties.Resources.verso;
                        item.Refresh();
                    }
                }
            }
        }


        private void final_jogo()
        {
            if (cartas_encontradas == 20)
            {
                MessageBox.Show("Parabéns, você terminou o jogo" + movimentos.ToString() + " movimentos");
                DialogResult msg = MessageBox.Show("Deseja continuar jogando?", "Caixa de pergunta", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    cliques = 0; movimentos = 0; cartas_encontradas = 0;
                    lista.Clear();
                    inicio();

                }
                else if (msg == DialogResult.No)
                {
                    MessageBox.Show("Obrigado por jogar");
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

