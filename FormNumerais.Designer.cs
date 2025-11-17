using System.Windows.Forms;
using System.Xml.Linq;

namespace LIBRAS_PARA_TODOS
{
    partial class FormNumerais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNumerais));
            BtnVoltar = new Button();
            Lbl_Titulo = new Label();
            picGrandeDisplay = new PictureBox();
            pictureBox0 = new PictureBox();
            label0 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            pictureBox8 = new PictureBox();
            label9 = new Label();
            pictureBox9 = new PictureBox();
            labelSoma = new Label();
            pictureBoxSoma = new PictureBox();
            labelSub = new Label();
            pictureBoxSub = new PictureBox();
            labelMulti = new Label();
            pictureBoxMulti = new PictureBox();
            labelDiv = new Label();
            pictureBoxDiv = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picGrandeDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSoma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMulti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiv).BeginInit();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.Transparent;
            BtnVoltar.BackgroundImage = (Image)resources.GetObject("BtnVoltar.BackgroundImage");
            BtnVoltar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Location = new Point(12, 566);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(130, 79);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.BackColor = Color.Transparent;
            Lbl_Titulo.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lbl_Titulo.ForeColor = Color.FromArgb(237, 187, 48);
            Lbl_Titulo.Location = new Point(12, 9);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(1123, 82);
            Lbl_Titulo.TabIndex = 2;
            Lbl_Titulo.Text = "NUMERAIS E SINAIS";
            Lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picGrandeDisplay
            // 
            picGrandeDisplay.BackColor = Color.FromArgb(40, 90, 160);
            picGrandeDisplay.BackgroundImage = Properties.Resources.verso;
            picGrandeDisplay.BackgroundImageLayout = ImageLayout.Stretch;
            picGrandeDisplay.BorderStyle = BorderStyle.Fixed3D;
            picGrandeDisplay.Location = new Point(40, 100);
            picGrandeDisplay.Name = "picGrandeDisplay";
            picGrandeDisplay.Size = new Size(450, 450);
            picGrandeDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            picGrandeDisplay.TabIndex = 31;
            picGrandeDisplay.TabStop = false;
            // 
            // pictureBox0
            // 
            pictureBox0.BackgroundImage = Properties.Resources.libras_0;
            pictureBox0.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox0.Cursor = Cursors.Hand;
            pictureBox0.Location = new Point(551, 132);
            pictureBox0.Name = "pictureBox0";
            pictureBox0.Size = new Size(100, 100);
            pictureBox0.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox0.TabIndex = 3;
            pictureBox0.TabStop = false;
            pictureBox0.Click += picPequeno_Click;
            // 
            // label0
            // 
            label0.BackColor = Color.Transparent;
            label0.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label0.ForeColor = Color.FromArgb(237, 187, 48);
            label0.Location = new Point(551, 235);
            label0.Name = "label0";
            label0.Size = new Size(100, 30);
            label0.TabIndex = 4;
            label0.Text = "ZERO";
            label0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(237, 187, 48);
            label1.Location = new Point(661, 235);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 6;
            label1.Text = "UM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.libras_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(661, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += picPequeno_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(237, 187, 48);
            label2.Location = new Point(771, 235);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 8;
            label2.Text = "DOIS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.libras_2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(771, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += picPequeno_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(237, 187, 48);
            label3.Location = new Point(881, 235);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 10;
            label3.Text = "TRÊS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.libras_3;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(881, 132);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += picPequeno_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(237, 187, 48);
            label4.Location = new Point(991, 235);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 12;
            label4.Text = "QUATRO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.libras_4;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(991, 132);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += picPequeno_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(237, 187, 48);
            label5.Location = new Point(551, 368);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 14;
            label5.Text = "CINCO";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.libras_5;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Location = new Point(551, 265);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += picPequeno_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(237, 187, 48);
            label6.Location = new Point(661, 368);
            label6.Name = "label6";
            label6.Size = new Size(100, 30);
            label6.TabIndex = 16;
            label6.Text = "SEIS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.libras_6;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Location = new Point(661, 265);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 100);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            pictureBox6.Click += picPequeno_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(237, 187, 48);
            label7.Location = new Point(771, 368);
            label7.Name = "label7";
            label7.Size = new Size(100, 30);
            label7.TabIndex = 18;
            label7.Text = "SETE";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.libras_7;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Location = new Point(771, 265);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 100);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            pictureBox7.Click += picPequeno_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(237, 187, 48);
            label8.Location = new Point(881, 368);
            label8.Name = "label8";
            label8.Size = new Size(100, 30);
            label8.TabIndex = 20;
            label8.Text = "OITO";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.libras_8;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Location = new Point(881, 265);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 100);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            pictureBox8.Click += picPequeno_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(237, 187, 48);
            label9.Location = new Point(991, 368);
            label9.Name = "label9";
            label9.Size = new Size(100, 30);
            label9.TabIndex = 22;
            label9.Text = "NOVE";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources.libras_9;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Location = new Point(991, 265);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 100);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 21;
            pictureBox9.TabStop = false;
            pictureBox9.Click += picPequeno_Click;
            // 
            // labelSoma
            // 
            labelSoma.BackColor = Color.Transparent;
            labelSoma.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            labelSoma.ForeColor = Color.FromArgb(237, 187, 48);
            labelSoma.Location = new Point(605, 523);
            labelSoma.Name = "labelSoma";
            labelSoma.Size = new Size(100, 30);
            labelSoma.TabIndex = 24;
            labelSoma.Text = "SOMA";
            labelSoma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxSoma
            // 
            pictureBoxSoma.BackgroundImage = Properties.Resources.libras_soma;
            pictureBoxSoma.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSoma.Cursor = Cursors.Hand;
            pictureBoxSoma.Location = new Point(605, 420);
            pictureBoxSoma.Name = "pictureBoxSoma";
            pictureBoxSoma.Size = new Size(100, 100);
            pictureBoxSoma.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSoma.TabIndex = 23;
            pictureBoxSoma.TabStop = false;
            pictureBoxSoma.Click += picPequeno_Click;
            // 
            // labelSub
            // 
            labelSub.BackColor = Color.Transparent;
            labelSub.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            labelSub.ForeColor = Color.FromArgb(237, 187, 48);
            labelSub.Location = new Point(715, 523);
            labelSub.Name = "labelSub";
            labelSub.Size = new Size(111, 30);
            labelSub.TabIndex = 26;
            labelSub.Text = "SUBTRAÇÃO";
            labelSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxSub
            // 
            pictureBoxSub.BackgroundImage = Properties.Resources.libras_subtracao;
            pictureBoxSub.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSub.Cursor = Cursors.Hand;
            pictureBoxSub.Location = new Point(715, 420);
            pictureBoxSub.Name = "pictureBoxSub";
            pictureBoxSub.Size = new Size(100, 100);
            pictureBoxSub.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSub.TabIndex = 25;
            pictureBoxSub.TabStop = false;
            pictureBoxSub.Click += picPequeno_Click;
            // 
            // labelMulti
            // 
            labelMulti.BackColor = Color.Transparent;
            labelMulti.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            labelMulti.ForeColor = Color.FromArgb(237, 187, 48);
            labelMulti.Location = new Point(821, 523);
            labelMulti.Name = "labelMulti";
            labelMulti.Size = new Size(137, 30);
            labelMulti.TabIndex = 28;
            labelMulti.Text = "MULTIPLICAÇÃO";
            labelMulti.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMulti
            // 
            pictureBoxMulti.BackgroundImage = Properties.Resources.libras_multiplicacao;
            pictureBoxMulti.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxMulti.Cursor = Cursors.Hand;
            pictureBoxMulti.Location = new Point(835, 420);
            pictureBoxMulti.Name = "pictureBoxMulti";
            pictureBoxMulti.Size = new Size(100, 100);
            pictureBoxMulti.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMulti.TabIndex = 27;
            pictureBoxMulti.TabStop = false;
            pictureBoxMulti.Click += picPequeno_Click;
            // 
            // labelDiv
            // 
            labelDiv.BackColor = Color.Transparent;
            labelDiv.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            labelDiv.ForeColor = Color.FromArgb(237, 187, 48);
            labelDiv.Location = new Point(955, 523);
            labelDiv.Name = "labelDiv";
            labelDiv.Size = new Size(110, 30);
            labelDiv.TabIndex = 30;
            labelDiv.Text = "DIVISÃO";
            labelDiv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDiv
            // 
            pictureBoxDiv.BackgroundImage = Properties.Resources.libras_divisao;
            pictureBoxDiv.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxDiv.Cursor = Cursors.Hand;
            pictureBoxDiv.Location = new Point(955, 420);
            pictureBoxDiv.Name = "pictureBoxDiv";
            pictureBoxDiv.Size = new Size(100, 100);
            pictureBoxDiv.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDiv.TabIndex = 29;
            pictureBoxDiv.TabStop = false;
            pictureBoxDiv.Click += picPequeno_Click;
            // 
            // FormNumerais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 126);
            ClientSize = new Size(1147, 645);
            Controls.Add(labelDiv);
            Controls.Add(pictureBoxDiv);
            Controls.Add(labelMulti);
            Controls.Add(pictureBoxMulti);
            Controls.Add(labelSub);
            Controls.Add(pictureBoxSub);
            Controls.Add(labelSoma);
            Controls.Add(pictureBoxSoma);
            Controls.Add(label9);
            Controls.Add(pictureBox9);
            Controls.Add(label8);
            Controls.Add(pictureBox8);
            Controls.Add(label7);
            Controls.Add(pictureBox7);
            Controls.Add(label6);
            Controls.Add(pictureBox6);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label0);
            Controls.Add(pictureBox0);
            Controls.Add(picGrandeDisplay);
            Controls.Add(Lbl_Titulo);
            Controls.Add(BtnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1147, 645);
            MinimumSize = new Size(1147, 645);
            Name = "FormNumerais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNumerais";
            Load += FormNumerais_Load;
            ((System.ComponentModel.ISupportInitialize)picGrandeDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSoma).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMulti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVoltar;
        private Label Lbl_Titulo;
        private PictureBox picGrandeDisplay; // NOVO
        private PictureBox pictureBox0;
        private Label label0;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label6;
        private PictureBox pictureBox6;
        private Label label7;
        private PictureBox pictureBox7;
        private Label label8;
        private PictureBox pictureBox8;
        private Label label9;
        private PictureBox pictureBox9;
        private Label labelSoma;
        private PictureBox pictureBoxSoma;
        private Label labelSub;
        private PictureBox pictureBoxSub;
        private Label labelMulti;
        private PictureBox pictureBoxMulti;
        private Label labelDiv;
        private PictureBox pictureBoxDiv;
    }
}
