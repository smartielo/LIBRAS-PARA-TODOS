namespace LIBRAS_PARA_TODOS
{
    partial class FormOQueELibras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOQueELibras));
            BtnVoltar = new Button();
            Lbl_Titulo = new Label();
            textBoxConteudo = new TextBox();
            picHistoria1 = new PictureBox();
            picHistoria2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picHistoria1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHistoria2).BeginInit();
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
            BtnVoltar.Location = new Point(12, 572);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(130, 61);
            BtnVoltar.TabIndex = 2;
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.BackColor = Color.Transparent;
            Lbl_Titulo.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Lbl_Titulo.ForeColor = Color.FromArgb(237, 187, 48);
            Lbl_Titulo.Location = new Point(331, 9);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(485, 82);
            Lbl_Titulo.TabIndex = 3;
            Lbl_Titulo.Text = "O QUE É LIBRAS?";
            Lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxConteudo
            // 
            textBoxConteudo.BackColor = Color.FromArgb(21, 49, 126);
            textBoxConteudo.BorderStyle = BorderStyle.None;
            textBoxConteudo.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxConteudo.ForeColor = Color.FromArgb(237, 187, 48);
            textBoxConteudo.Location = new Point(450, 150);
            textBoxConteudo.Multiline = true;
            textBoxConteudo.Name = "textBoxConteudo";
            textBoxConteudo.ReadOnly = true;
            textBoxConteudo.Size = new Size(650, 400);
            textBoxConteudo.TabIndex = 5;
            textBoxConteudo.Text = resources.GetString("textBoxConteudo.Text");
            // 
            // picHistoria1
            // 
            picHistoria1.BackgroundImage = Properties.Resources.oquee_img1;
            picHistoria1.BorderStyle = BorderStyle.Fixed3D;
            picHistoria1.Location = new Point(40, 150);
            picHistoria1.Name = "picHistoria1";
            picHistoria1.Size = new Size(380, 200);
            picHistoria1.SizeMode = PictureBoxSizeMode.Zoom;
            picHistoria1.TabIndex = 6;
            picHistoria1.TabStop = false;
            // 
            // picHistoria2
            // 
            picHistoria2.BackgroundImage = Properties.Resources.oquee_img2;
            picHistoria2.BackgroundImageLayout = ImageLayout.Stretch;
            picHistoria2.BorderStyle = BorderStyle.Fixed3D;
            picHistoria2.Location = new Point(40, 360);
            picHistoria2.Name = "picHistoria2";
            picHistoria2.Size = new Size(380, 190);
            picHistoria2.SizeMode = PictureBoxSizeMode.Zoom;
            picHistoria2.TabIndex = 7;
            picHistoria2.TabStop = false;
            // 
            // FormOQueELibras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 126);
            ClientSize = new Size(1147, 645);
            Controls.Add(picHistoria1);
            Controls.Add(picHistoria2);
            Controls.Add(textBoxConteudo);
            Controls.Add(Lbl_Titulo);
            Controls.Add(BtnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1147, 645);
            MinimumSize = new Size(1147, 645);
            Name = "FormOQueELibras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLibras";
            Load += FormOQueELibras_Load;
            ((System.ComponentModel.ISupportInitialize)picHistoria1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHistoria2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVoltar;
        private Label Lbl_Titulo;
        private TextBox textBoxConteudo;
        // Declaração dos novos PictureBox
        private PictureBox picHistoria1;
        private PictureBox picHistoria2;
    }
}